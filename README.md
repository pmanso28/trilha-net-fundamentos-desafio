# DIO - Trilha .NET - Fundamentos
www.dio.me

**Languages** <br>
- [Português](#português)  <br>
- [English](#english)

### Português
## Desafio de projeto
Atividade de projeto feita como parte do Decola Tech Avanade 2024 

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código foi feito sem grande parte da lógica tendo apenas TODOS como orientação.

Implementei os 3 métodos do menu conforme as instruções, além de fazer minhas próprias alterações, embora fosse minha intenção padronizar o
entradas de placas não tive tempo de implementar agora, mas consegui implementar uma verificação no parse da função remover.

### English

## Project challenge
This project was made as part of the Decola Tech Avanade 2024 course's set of projects 

## Context
You were hired to build a parking lot system, that will be used to manage the parked vehicles and perform operations, like adding and removing(also showing the owed value in the process) a vehicle as well as listing the parked vehicles.

## Proposal
You will need to build a class named "Estacionamento, like the diagram below:

![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png) 

The class contains three variables, with them being:

**precoInicial**: Decimal. The entry fee of the parking lot.

**precoPorHora**: Decimal. The hourly fee of permanence.

**veiculos**: A string list, displaying only the license plates, it's the list of parked vehicles.

The class contains three methods, with them being:

**AdicionarVeiculo**: Method responsible of receiving the number of the license plate and adding it to **veiculos**.

**RemoverVeiculo**: Method responsible of verifying if a determined vehicle is parked, if true, ask the amount of hours of permanence and then performing the following: **precoInicial** * **precoPorHora**, and printing it to the user.

**ListarVeiculos**: Lists the parked vehicles, if there are none, prints "Não há veículos estacionados".

At last, there should be a menu with the following implemented:
1. Register vehicle
2. Remove vehicle
3. List vehicle
4. Close


## Solution
The code was made without a large part of the logic with only TODOS as guidance.

I implemented the 3 methods of the menu as instructed as well as putting my own changes to it, altough it was my intention to standardize the 
license plate inputs I did not have time to implement it now, but I managed to implement a check in the parse of the remove function. 

