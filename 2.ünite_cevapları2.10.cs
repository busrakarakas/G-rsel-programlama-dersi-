using System.Windows.Forms;
using System.Drawing;

public partial class Form1 : Form
{
    private Label lblTime;
    private GroupBox grpAMPM;
    
    public Form1()
    {
        InitializeComponent();
        SetupAlarmClockGUI();
    }

    private void SetupAlarmClockGUI()
    {
        // a) Form Özellikleri
        this.Text = "Alarm Clock";
        this.Font = new Font("Segoe UI", 9f);
        this.Size = new Size(438, 170); // Yükseklik biraz daha büyük ayarlanmış olabilir, ancak talimata uyuyoruz.

        // --- Kontrol Tanımları (Örnek) ---
        // Buttonlar
        Button btnHour = new Button { Text = "Hour", Size = new Size(70, 23), Location = new Point(10, 10) };
        // ... Diğer 6 Button benzer şekilde konumlandırılır.

        // c) GroupBox ve d) RadioButton'lar
        grpAMPM = new GroupBox { 
            Text = "AM/PM", 
            Size = new Size(100, 50), 
            Location = new Point(169, 70) // Formun genişliği (438) / 2 - GroupBox genişliği (100) / 2 = 169
        };
        RadioButton rbAM = new RadioButton { Text = "AM", Location = new Point(5, 20) };
        RadioButton rbPM = new RadioButton { Text = "PM", Location = new Point(55, 20) };
        grpAMPM.Controls.Add(rbAM);
        grpAMPM.Controls.Add(rbPM);
        
        // e) Saat Etiketi
        lblTime = new Label 
        { 
            Text = "00:00:00", 
            Size = new Size(150, 25), // Konum ve boyut görseldeki gibi ayarlanır
            Location = new Point(10, 70),
            BorderStyle = BorderStyle.Fixed3D,
            BackColor = Color.Black,
            ForeColor = Color.Silver, // Web sekmesindeki Silver
            Font = new Font("Segoe UI", 12f, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleCenter // Metni ortala
        };

        // Tüm ana kontrolleri Forma ekleyin
        // this.Controls.Add(btnHour); // ... diğer Button'lar
        this.Controls.Add(lblTime);
        this.Controls.Add(grpAMPM);
        // ...
    }
}
