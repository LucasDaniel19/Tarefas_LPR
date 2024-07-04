#include <iostream>
#include <map>
#include <vector>
#include <algorithm>

using namespace std;

void imprimirMapa(const map<string, int>& mapa) {
    for (auto it = mapa.begin(); it != mapa.end(); ++it) {
        cout << it->first << " - Populacao: " << it->second << endl;
    }
}

int main() {
   
    map<string, int> cidades;

    
    cidades["Sao Paulo"] = 12000000;
    cidades["Rio de Janeiro"] = 6500000;
    cidades["Belo Horizonte"] = 2500000;
    cidades["Brasilia"] = 3000000;
    cidades["Salvador"] = 2800000;

    
    cout << "Mapa original:" << endl;
    imprimirMapa(cidades);

   
    double mediaPopulacao = 0.0;
    for (const auto& cidade : cidades) {
        mediaPopulacao += cidade.second;
    }
    mediaPopulacao /= cidades.size();

   
    cout << "\nCidades com populacao acima da media:" << endl;
    for (const auto& cidade : cidades) {
        if (cidade.second > mediaPopulacao) {
            cout << cidade.first << " - Populacao: " << cidade.second << endl;
        }
    }

    
    auto cidadeMaisPopulosa = max_element(cidades.begin(), cidades.end(),
        [](const pair<string, int>& p1, const pair<string, int>& p2) {
            return p1.second < p2.second;
        });
    cout << "\nCidade mais populosa: " << cidadeMaisPopulosa->first << endl;

    
    auto cidadeMenosPopulosa = min_element(cidades.begin(), cidades.end(),
        [](const pair<string, int>& p1, const pair<string, int>& p2) {
            return p1.second < p2.second;
        });
    cout << "Cidade menos populosa: " << cidadeMenosPopulosa->first << endl;

    
    int valorY;
    cout << "\nDigite a populacao Y para remover cidades com essa populacao: ";
    cin >> valorY;

    
    vector<string> chavesParaRemover;
    for (const auto& cidade : cidades) {
        if (cidade.second == valorY) {
            chavesParaRemover.push_back(cidade.first);
        }
    }

   
    for (const auto& chave : chavesParaRemover) {
        cidades.erase(chave);
    }

    
    cout << "Mapa atualizado apos remocao:" << endl;
    imprimirMapa(cidades);

    return 0;
}
