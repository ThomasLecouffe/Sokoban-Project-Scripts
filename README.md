# Sokoban Generator

Sokoban Generator est un jeu créer lors de l'UV Projet effectué à IMT Lille Douai. Sokoban Generator est avant tout un générateur de level sokoban. Sokoban est un jeu vidéo où vous contrôler un  personnage qui doit bouger des caisses pour les mettre sur un objectif précis. 

## Pour commencer

Notre projet peut être exécuté sur plusieurs environnements mais il a été conçu pour être joué à partir d'un exécutable windows ou linux

Les builds pour Windows et linux  sont disponible [ici ](https://tlecouffe.itch.io/chicken-roll).  

### Installation

- Télécharger le build correspondant à votre plateforme

##### Windows 

Lancer le .exe

##### Linux

Lancer ces commandes

```shell
unzip build.zip
cd build
chmod +x buildLinux.x86_64
./buildLinux.x86_64
```



## Contrôles

### Déplacement

 ZQSD : Pour se déplacer dans le niveau

### Generator UI

![](https://github.com/ThomasLecouffe/Sokoban-Project-Scripts/blob/main/media/1605233119604.png)

#### 1) Graphical Selector Palet

Cet élément est utilisé pour changer la couleur du niveau. Afin de rendre l'expérience utilisateur plus agréable, nous avons convenu que la sélection aléatoire de couleur n'était pas disponible pour le moment. 

#### 2) Options selector

##### Width

Ce sélecteur a été conçu pour permettre un choix optimal du niveau selon l'envie de l'utilisateur. Afin de rester dans notre choix de concevoir une expérience confortable pour l'utilisateur, nous avons mis la possibilité de créer des niveaux allant d'une taille de 3 à 11. 

La taille correspond au nombre de templates utilisé pour générer le niveau. Un template étant un objet de 3x3 un niveau de taille 3 correspond à une taille de 9x9.

##### Number of crates

Ce sélecteur permet de sélectionner le nombre de boîtes et d'objectifs présent dans le niveau. 

#### 3) Optimize button

Ce bouton appelle la fonction post processing de notre générateur. Il exécute certaines tâches permettant de rendre le niveau meilleur. Parmi celles-ci, on peut noter la suppression des zones mortes ainsi que la suppression de certains blocs isolés.  

#### 4) Generate button 

Ce bouton génère un nouveau niveau selon les paramètres sélectionnés (1 et 2). A utiliser avant le bouton d'optimisation 

#### 5)  Niveau généré

C'est dans cette fenêtre que le niveau apparaîtra. Le jeu peut-être testé ici.

## Fabriqué avec

- [Unity 3D](https://unity.com/) 

## Auteurs

- **Hugo Sergeant** 
- **Thomas Lecouffe**