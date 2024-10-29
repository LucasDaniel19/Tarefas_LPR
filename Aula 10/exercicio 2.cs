#include <iostream>
#include <vector>
#include <algorithm>
#include <ctime>
#include <cstdlib>
#include <unordered_set>

using namespace std;


int gerarNumeroAleatorio() {
    return rand() % 100 + 1;
}

int main() {
    srand(time(nullptr));
   
    vector<int> lista;
    for (int i = 0; i < 100; ++i) {
        lista.push_back(gerarNumeroAleatorio());
    }

    sort(lista.begin(), lista.end());

    vector<int> listaSemPares;
    for (int num : lista) {
        if (num % 2 != 0) {
            listaSemPares.push_back(num);
        }
    }

    cout << "Lista ordenada sem numeros pares:" << endl;
    for (int num : listaSemPares) {
        cout << num << " ";
    }
    cout << endl;
    unordered_set<int> numerosRepetidos;
    unordered_set<int> numerosVistos;

    for (int num : listaSemPares) {
        if (numerosVistos.find(num) != numerosVistos.end()) {
            numerosRepetidos.insert(num);
        }
        else {
            numerosVistos.insert(num);
        }
    }

    if (numerosRepetidos.empty()) {
        cout << "Nao ha numeros repetidos na lista." << endl;
    }
    else {
        cout << "Numeros que se repetem na lista:" << endl;
        for (int num : numerosRepetidos) {
            cout << num << " ";
        }
        cout << endl;
    }

    return 0;
}
