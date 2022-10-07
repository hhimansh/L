/**
 * @param {string} s
 * @return {number}
 */
 var romanToInt = function(s) {
    a = "I";
    b = "V";
    c = "X";
    d = "L";
    e = "C";
    f = "D";
    g = "M";
    h = "O";
    input = [];
    input[0] = h;
    input[1] = a;
    input[5] = b;
    input[10] = c;
    input[50] = d;
    input[100] = e;
    input[500] = d;
    input[1000] = g;
    // input[10001] = h
    total = 0;
    
    for(i=s.length-1;i>=0;i=i-2){
      if(s.length >= 2){
        firstVar = s.charAt(i);
        if(i-1 < 0){
          secondVar = "O";
        }else{
          secondVar = s.charAt(i-1);
        }
        if(input.indexOf(firstVar) <= input.indexOf(secondVar) || secondVar == "O"){
          total += input.indexOf(firstVar) + input.indexOf(secondVar);
        }
        else{
          total += input.indexOf(firstVar) - input.indexOf(secondVar);
        }
      }
    }
    return total;
};