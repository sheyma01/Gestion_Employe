### Fonctionnalités :

1. **Gestion d'Employés** : Le code gère un tableau (`tabEmployes`) d'employés, chacun ayant un numéro, un nom, une fonction et un salaire.
   
2. **Chargement de Données**: À la chargement du formulaire (`frmExamFinal_Load`), les données sont lues à partir d'un fichier texte (`Compagnie.txt`) et chargées dans le tableau.
  
3. **Affichage et Navigation**: Les utilisateurs peuvent naviguer entre les différents employés à l'aide des boutons "Premier", "Dernier", "Précédent", et "Suivant".

4. **Ajout et Modification**: Les utilisateurs peuvent ajouter de nouveaux employés et modifier les employés existants.

5. **Sauvegarde de Données**: À la fermeture du formulaire (`frmExamFinal_FormClosing`), les données sont sauvegardées dans le fichier `Compagnie.txt`.

### Techniques et Technologies :

1. **Windows Forms**: Utilisé pour l'interface utilisateur.
  
2. **StreamReader/StreamWriter**: Utilisé pour la lecture et l'écriture de fichiers.
  
3. **Structures**: Utilisé pour définir le format des employés (`struct Employe`).
  
4. **Gestion d'Événements**: Utilisé pour gérer les actions de l'utilisateur comme les clics de bouton.

En résumé, ce projet est une application de gestion d'employés simple mais fonctionnelle, avec des fonctionnalités de chargement et de sauvegarde de données.