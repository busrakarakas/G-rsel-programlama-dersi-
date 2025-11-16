using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    // Hesap makinesinin durumunu tutan alanlar
    private double result = 0;
    private string operationPerformed = "";
    private bool isOperationPerformed = false;
    
    // Kontrol alanları
    private TextBox displayTextBox;
    
    public Form1()
    {
        // Tasarımcı tarafından oluşturulan metot yerine kendi kurulumumuzu çağırıyoruz.
        InitializeCalculatorGUI(); 
    }

    private void InitializeCalculatorGUI()
    {
        // a) Form Özellikleri
        this.Text = "Calculator";
        this.Font = new Font("Segoe UI", 9f);
        this.ClientSize = new Size(258, 210); // ClientSize kullanarak boyutlandırma

        // b) TextBox Ekleme (230, 20 boyutunda genişletilmiş)
        displayTextBox = new TextBox();
        displayTextBox.Location = new Point(5, 5);
        displayTextBox.Size = new Size(230, 25); 
        displayTextBox.TextAlign = HorizontalAlignment.Right;
        displayTextBox.Text = "0";
        this.Controls.Add(displayTextBox);

        // Paneller ve Düğmeler için başlangıç koordinatları ve boyutları
        int buttonSize = 23;
        int currentX = 5;
        int currentY = 35;
        
        // --- c) İlk Panel (Sayılar: 90, 120) ---
        Panel panel1 = new Panel { 
            BorderStyle = BorderStyle.Fixed3D, 
            Size = new Size(90, 120), 
            Location = new Point(currentX, currentY) 
        };
        this.Controls.Add(panel1);
        
        // --- d) İkinci Panel (Operatörler: 62, 120) ---
        currentX += 90 + 5;
        Panel panel2 = new Panel { 
            BorderStyle = BorderStyle.Fixed3D, 
            Size = new Size(62, 120), 
            Location = new Point(currentX, currentY) 
        };
        this.Controls.Add(panel2);

        // --- e) Üçüncü Panel (Kontroller: C, C/A, OFF) ---
        currentX += 62 + 5;
        Panel panel3 = new Panel { 
            BorderStyle = BorderStyle.Fixed3D, 
            Size = new Size(54, 62), 
            Location = new Point(currentX, currentY) 
        };
        this.Controls.Add(panel3);
        
        // --- f) Buton Ekleme (20 Adet) ---
        
        // Sayı ve Nokta Butonları (Panel 1 içine)
        string[] numberButtons = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "00", "." };
        int px = 5;
        int py = 5;
        
        // 9 adet standart sayı butonu (3x3 grid)
        for (int i = 0; i < 9; i++)
        {
            Button btn = CreateButton(numberButtons[i], new Size(buttonSize, buttonSize), new Point(px, py));
            btn.Click += NumberButton_Click;
            panel1.Controls.Add(btn);
            
            px += buttonSize + 5;
            if ((i + 1) % 3 == 0)
            {
                px = 5;
                py += buttonSize + 5;
            }
        }
        
        // 0 ve 00 Butonları
        Button btn0 = CreateButton("0", new Size(buttonSize, buttonSize), new Point(5, 87));
        btn0.Click += NumberButton_Click;
        panel1.Controls.Add(btn0);

        Button btn00 = CreateButton("00", new Size(52, buttonSize), new Point(33, 87)); // Boyut: 52, 23
        btn00.Click += NumberButton_Click;
        panel1.Controls.Add(btn00);
        
        // Nokta Butonu
        Button btnDot = CreateButton(".", new Size(buttonSize, buttonSize), new Point(5, 87));
        btnDot.Location = new Point(33 + 52 + 5, 87);
        btnDot.Click += NumberButton_Click;
        panel1.Controls.Add(btnDot); // Konum görselden biraz farklı olabilir.
        
        // Operatör Butonları (Panel 2 içine)
        string[] operators = { "-", "*", "/", "=" };
        py = 5;
        
        // Eksi, Çarpı, Bölü, Eşittir Butonları
        foreach (string op in operators)
        {
            Button btn = CreateButton(op, new Size(buttonSize, buttonSize), new Point(5, py));
            if (op != "=")
            {
                btn.Click += OperatorButton_Click;
            }
            else
            {
                btn.Click += EqualsButton_Click;
            }
            panel2.Controls.Add(btn);
            py += buttonSize + 5;
        }
        
        // Artı Butonu (Dikey olarak uzun)
        Button btnPlus = CreateButton("+", new Size(buttonSize, 81), new Point(33, 5)); // Boyut: 23, 81
        btnPlus.Click += OperatorButton_Click;
        panel2.Controls.Add(btnPlus);
        
        // Kontrol Butonları (Panel 3 içine)
        // C ve C/A Butonları (Boyut: 44, 23)
        Button btnC = CreateButton("C", new Size(44, buttonSize), new Point(5, 5));
        btnC.Click += ClearButton_Click;
        panel3.Controls.Add(btnC);

        Button btnCA = CreateButton("C/A", new Size(44, buttonSize), new Point(5, 33));
        btnCA.Click += ClearAllButton_Click;
        panel3.Controls.Add(btnCA);

        // OFF Butonu (Boyut: 54, 23) - Panel dışına, Panel 3'ün altına yerleştirildi
        Button btnOff = CreateButton("OFF", new Size(54, buttonSize), new Point(currentX, currentY + 62 + 5));
        btnOff.Click += OffButton_Click;
        this.Controls.Add(btnOff);
    }
    
    // Yardımcı metot: Button nesnesi oluşturur
    private Button CreateButton(string text, Size size, Point location)
    {
        return new Button 
        { 
            Text = text, 
            Size = size, 
            Location = location 
        };
    }

    // --- OLAY İŞLEYİCİLERİ ---
    
    private void NumberButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        
        if ((displayTextBox.Text == "0") || (isOperationPerformed))
        {
            displayTextBox.Clear();
            isOperationPerformed = false;
        }

        if (button.Text == ".")
        {
            if (!displayTextBox.Text.Contains("."))
            {
                displayTextBox.Text += button.Text;
            }
        }
        else 
        {
            displayTextBox.Text += button.Text;
        }
    }

    private void OperatorButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        
        if (result != 0)
        {
            // Eğer varsa önceki işlemi sonuçlandır
            EqualsButton_Click(null, null); 
        }

        operationPerformed = button.Text;
        if (Double.TryParse(displayTextBox.Text, out double number))
        {
             result = number;
        }
        isOperationPerformed = true;
    }

    private void EqualsButton_Click(object sender, EventArgs e)
    {
        if (operationPerformed == "") 
            return;

        if (!Double.TryParse(displayTextBox.Text, out double currentValue))
            return;
        
        switch (operationPerformed)
        {
            case "+":
                result += currentValue;
                break;
            case "-":
                result -= currentValue;
                break;
            case "*":
                result *= currentValue;
                break;
            case "/":
                if (currentValue != 0)
                {
                    result /= currentValue;
                }
                else
                {
                    MessageBox.Show("Sıfıra Bölme Hatası!");
                    ClearAllButton_Click(null, null);
                    return;
                }
                break;
        }
        
        displayTextBox.Text = result.ToString();
        operationPerformed = "";
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        displayTextBox.Text = "0";
    }

    private void ClearAllButton_Click(object sender, EventArgs e)
    {
        displayTextBox.Text = "0";
        result = 0;
        operationPerformed = "";
        isOperationPerformed = false;
    }

    private void OffButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
