

#include <iostream>
using namespace std;

int main()
{
    int escolha;

     cout << "Escolha a classe" << endl;
     cout << "1.Guerreira" << endl;
     cout << "2.Mago" << endl;
     cout << "3.Arqueira" << endl;
     cin >> escolha;
     
     switch (escolha)
     {
     case 1:
        cout << "Ataque Pesado, Defesa Total" << endl;
         break;
     case 2:
         cout << "Bola de Fogo, Escudo de Gelo" << endl;
         break;
     case 3:
         cout << "Flecha Precisa, Disparo Triplo" << endl;
         break;
     }

}

