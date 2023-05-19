string palavra = "temem";

string str = palavra.Replace(" ", String.Empty);
char[] chars = str.ToCharArray();
Array.Reverse(chars);
string strReverse = new string(chars);

string strPotencial = palavra.Replace(" ", String.Empty);
chars = strPotencial.ToCharArray();
Array.Sort(chars);
strPotencial = new string(chars);

bool potencial = true;
for (int i = 1; i < strPotencial.Length; i += 2) {
    if(strPotencial[i] != strPotencial[i-1])
    {
        potencial = false;
    }  
}
if(str == strReverse || palavra == "" || potencial){
    return true;
} else {
    return false;
}
