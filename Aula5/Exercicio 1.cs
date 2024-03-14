// ConsoleApplication3.cpp : Este arquivo contém a função 'main'. A execução do programa começa e termina ali.
//

#include <iostream>
using namespace std;

int main()
{ 
    int numero;
     cout << "Dgite um numero ";
     cin >> numero;


     if (numero %2 == 0){
         cout << "Seu numero e par " << numero << endl;
     }
     else if (numero){
         cout << "Seu numero e impar " << numero << endl;
     }
}

