int[] numeros = {3,3};
int objetivo = 6;

List<int> index = new List<int>();
for (int i = 0; i < numeros.Length; i++) {
    System.Console.WriteLine(numeros[i]);
    for (int j = i+1; j < numeros.Length; j++) {
        System.Console.WriteLine(numeros[j]);
        if (numeros[i] + numeros[j] == objetivo){
            index.Add(i);
            index.Add(j);
        }
    }      
}
return index.ToArray();
