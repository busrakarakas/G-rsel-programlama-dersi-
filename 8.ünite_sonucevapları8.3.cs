a) const int ArraySize = 10; 
b) var fractions = new double[ArraySize]; 
c) fractions[3] 
d) fractions[9] = 1.667; 
e) fractions[6] = 3.333; 
f) var total = 0.0;
 for (var x = 0; x < fractions.Length; ++x)
 {
 total += fractions[x];
 }
 g) var total = 0.0;
 foreach (var element in fractions)
 {
 total += element;
 }
