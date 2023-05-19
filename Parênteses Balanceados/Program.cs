string palavra = "(()()((())()((";

int countParenteseEsq = 0;
int countParenteseDir = 0;
foreach(char parentese in palavra)
{
    if(parentese == '(')
    {
        countParenteseEsq++;
    }
    else if (parentese == ')')
    {
        countParenteseDir++;
    }
}
return Math.Abs(countParenteseEsq-countParenteseDir);