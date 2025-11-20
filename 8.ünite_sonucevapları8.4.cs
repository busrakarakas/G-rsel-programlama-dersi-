a) var table = new int[ArraySize, ArraySize]; 
b) Nine. 
c) for (var x = 0; x < table.GetLength(0); ++x)
 {
 for (var y = 0; y < table.GetLength(1); ++y)
 {
   table[x, y] = x + y;
 }
 }
