#include <iostream>
#include <string>
using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;
};

int main() {
    Livro livros[3];
    double precoTotal = 0;
    int totalPaginas = 0;

    for (int i = 0; i < 3; i++) {
        cout << "Insira os dados do livro " << (i + 1) << ":" << endl;

        cout << "Título: ";
        cin.ignore();
        getline(cin, livros[i].Titulo);

        cout << "Autor: ";
        getline(cin, livros[i].Autor);

        cout << "Ano de Publicação: ";
        cin >> livros[i].AnoPublicacao;

        cout << "Número de Páginas: ";
        cin >> livros[i].NumeroPaginas;

        cout << "Preço: ";
        cin >> livros[i].Preco;

        precoTotal += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;

        cout << endl;
    }

    double mediaPaginas = totalPaginas / 3.0;

    cout << "Preço total dos livros: " << precoTotal << endl;
    cout << "Média de páginas dos livros: " << mediaPaginas << endl;

    return 0;
}
