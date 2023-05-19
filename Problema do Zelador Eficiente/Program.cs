double[] pesos = {1.01, 1.993, 1.32, 1.7, 1.8};

double[] pesosOrdenados = pesos.OrderBy(x => x).Reverse().ToArray();
const int max = 3;
int viagens = 0;
for(int i = 0; i < pesosOrdenados.Length; i++){
    if(pesosOrdenados[i] != 0){
        double peso = pesosOrdenados[i];
        int indexJ = 0;
        for (int j = 1; j < pesosOrdenados.Length; j++) {
            if(pesosOrdenados[j] != 0){
                if((peso + pesosOrdenados[j] > peso) && (peso + pesosOrdenados[j] <= max)) {
                    peso += pesosOrdenados[j];
                    indexJ = j;
                }
            }
        }
        viagens++;
        pesosOrdenados[i] = 0;
        pesosOrdenados[indexJ] = 0;
    }
}
return viagens;