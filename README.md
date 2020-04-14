# TP3-DesignPattern
#####par Ambre Donnadieu dans le cadre du cours 8INF956-Développement avancé de logiciel : Patrons et Modèles de l'UQAC

## Question 1: Comment organisez vous votre solution ? (Combien de projet? Quels types de projets?)

La solution est organisée de la manière suivante : 
- un projet console de base qui permet l'utilisation des fonctions du plugin
- un projet constituant le plugin dans lequel les méthodes seront détaillées.

## Question 2 : Dans quel projet mettez-vous la classe User? 
### Celle-ci est composée d'un nom, d'un prénom et d'une adresse mail.

La classe user est dans la partie plugin car le rôle de celui-ci est de "convertir" un fichier json d'utilisateur en liste json.

## Question 3 : En vous basant sur la documentation, à quoi ressemble l'interface d'un plugin dans notre système? 
### (N'oubliez pas il doit pouvoir charger une liste d'utilisateur)

Dans notre cas, l'interface ne comportera qu'une fonction permettant de prendre un fichier json et de le convertir en liste d'utilisateur.
La partie de lecture/écriture/encodage du fichier json est elle gérée par la librairy Newtonsoft.Json.