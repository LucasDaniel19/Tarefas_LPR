#include <iostream>

using namespace std;

int main() {
    int numero;
    cout << "Digite um numero: ";
    cin >> numero;

    int quadrado = numero * numero;
    int soma_digitos = 0;

    while (quadrado > 0) {
        int digito = quadrado % 10;
        soma_digitos += digito;
        quadrado /= 10;
    }

    cout << "A soma dos numeros e " << soma_digitos << endl;

}