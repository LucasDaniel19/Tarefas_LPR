#include <iostream>
#include <random>

using namespace std;

int main() {
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio);
    int tentativas = 0;
    int chute;

    cout << "Adivinhacao" << endl;

    do {
        cout << "Digite um numero entre 1 e 100: ";
        cin >> chute;
        tentativas++;

        if (chute < valorInteiro) {
            cout << "Chutou baixo!" << endl;
        }
        else if (chute > valorInteiro) {
            cout << "Chutou alto!" << endl;
        }
        else {
            cout << "você acertou o numero" << endl;
        }
    } while (chute != valorInteiro);

    cout << "Você acertou em " << tentativas << " tentativas." << endl;

}
