# ParkingProject 🚗

Um projeto simples em C# para simular um sistema de estacionamento com funcionalidades de cadastro, listagem e remoção de veículos.

## 📋 Descrição

Este projeto foi desenvolvido com o objetivo de praticar conceitos de orientação a objetos em C# aprendidos no Bootcamp "WEX - end to end engineering" da DIO, trabalhando com listas, entrada de dados, e controle de fluxo. O sistema permite:

- Cadastrar um veículo com placa
- Listar veículos estacionados
- Remover veículo pelo número da placa
- Calcular o valor da estadia com base em preço fixo + valor por hora

## 🛠️ Como executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/Ramos902/ParkingProject.git
   cd ParkingProject/ParkingProject
   ```

2. Compile e execute com o .NET CLI:
   ```bash
   dotnet run
   ```

> Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado em sua máquina.

## 🧱 Estrutura de Classes

### `Parking`
Classe principal que representa o estacionamento.

**Propriedades:**
- `InitialPrice`: valor fixo da entrada
- `PricePerHour`: valor adicional por hora
- `Vehicles`: lista de placas de veículos estacionados

**Métodos principais:**
- `AddVehicle()`: solicita uma placa e adiciona à lista
- `RemoveCar(string plate)`: remove o veículo com base na placa e calcula o valor da estadia
- `ListVehicles()`: exibe todos os veículos estacionados

### `Program`
Classe que contém o método `Main`. Exibe o menu principal com opções para o usuário:

- 1: Cadastrar veículo  
- 2: Remover veículo  
- 3: Listar veículos  
- 4: Encerrar programa

## 💡 Exemplo de uso

```bash
========| Parking System |========
Input the Initial Price::
=> 5
Input the Hour Price:
=> 2

Input your option
1 - Add Vehicle
2 - Remove Vehicle
3 - List Vehicle
4 - End Program

================| Adding Car |==================
=> 1
Input the car model:
=> Honda Civic
Input the car plate:
=> ABC-1234
Input the car year:
=> 2020
Car added from parking! Press enter to Continue!

===============| Removing Car |=================
=> 2
Input the car plate:
=> ABC-1234
Input how much hours the car was parking:
=> 3
Car removed from parking!
With the total = R$11,00
Press enter to Continue!

================| Listing Cars |================
=> 3
Model: Honda Civic | Plate: ABC-1234 | Year: 2020
Press enter to Continue!

================================================
=> 4
Program Exit! Press enter to continue.
```
Feito com 💻 por [João Ramos](https://github.com/Ramos902)
