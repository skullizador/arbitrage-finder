<h1 align="center"> Arbitrage Finder </h1> <br>

<p align="center">
  This microservice is responsible for finding the maximum amount of arbritage bets possible in a game. For it it will receive a list of odds from several bookmakers that combined with each other using a specific formula can become sure bets.
</p>

## Table of Contents

- [Domain](#introduction)
- [Features](#features)
- [Requirements](#requirements)
- [Quick Start](#quick-start)

## Domain

![Domain](https://github.com/skullizador/arbitrage-finder/blob/main/resources/domain.png)

## Features

* [x] Calculate sure bets by game;
* [x] Get all sure bets by game;
* [x] Get sure bets by filter;
* [x] Get sure bets details;
* [x] Get game details;
* [x] Get games by filter;

## Requirements
The application can be run locally or in a docker container, the requirements for each setup are listed below.

### Docker
* [Docker](https://www.docker.com/get-docker)

## Quick Start 
### Run Docker
TODO: Implement dockerfiles to run the application in a docker container.

First build the image:
```bash
$ docker-compose build
```

When ready, run it:
```bash
$ docker-compose up
```

Application will run by default on port `1234`