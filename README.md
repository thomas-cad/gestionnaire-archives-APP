# Gestion d'Archive

## À Propos

Ce projet est développé dans le cadre d'un projet étudiant à Télécom Saint-Étienne. L'application de gestion d'archives vise à faciliter l'organisation et la gestion des archives physiques. Utilisant une interface homme-machine (IHM) conçue en C# en lien avec une base de données PostgreSQL hébergée sur Azure, cette application s'adresse aux institutions ayant besoin de gérer efficacement leurs documents et archives.

## Prérequis

Avant de commencer, assurez-vous d'avoir installé les éléments suivants sur votre système :
- .NET Framework (Version spécifique)
- Visual Studio ou tout autre IDE compatible avec le développement C#

## Installation

Pour installer et configurer le projet sur votre système, suivez ces étapes :
1. Clonez le dépôt sur votre machine locale.
2. Ouvrez le projet dans Visual Studio ou dans votre IDE de choix.
3. Installez les packages NuGet nécessaires via le gestionnaire de packages ou en utilisant les commandes suivantes dans la console de gestion de packages :
   - `Install-Package ReaLTaiizor -Version 3.8.0.2`
   - `Install-Package Npgsql -Version 8.0.2`
   - `Install-Package itext7 -Version 8.0.3`

## Configuration

Après l'installation, configurez les variables d'environnement suivantes pour permettre à l'application de se connecter à votre base de données :
- `DB_ARCHIVE_HOST`: Adresse de l'hôte de votre base de données.
- `DB_ARCHIVE_PORT`: Port de connexion à votre base de données.
- `DB_ARCHIVE_PWD`: Mot de passe de votre base de données.
- `DB_ARCHIVE_USER`: Nom d'utilisateur pour la connexion à votre base de données.

Vous trouverez le modèle relationnel de la base de données (MR BDD) à la racine du répertoire du projet.

## Utilisation



## Contribution

Nous accueillons avec plaisir les contributions de la communauté ! Si vous souhaitez contribuer, veuillez suivre ces étapes :
1. Fork le projet.
2. Créez votre branche de fonctionnalité (`git checkout -b feature/AmazingFeature`).
3. Commitez vos changements (`git commit -m 'Add some AmazingFeature'`).
4. Poussez vers la branche (`git push origin feature/AmazingFeature`).
5. Ouvrez une Pull Request.

## Licence

Ce projet est distribué sous la Licence MIT. Voir le fichier `LICENSE` pour plus d'informations.

## Contributeurs

- Thomas Cadegros
- Amine Slaoui

## Contact

- Thomas Cadegros - [thomas.cadegros@telecom-st-etienne.fr]
- Amine Slaoui - [amine.slaoui@telecom-st-etienne.fr]

Projet Lien: [https://gitlab.com/votreprojet/gestion-archive](https://gitlab.com/votreprojet/gestion-archive)
