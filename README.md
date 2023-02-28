# Application-TransConnect
Application pour une société fictive. 

Il s’agit d’un projet de création d’application pour le compte d’une entreprise qui réalise du transport de marchandise. 
Cette application doit être capable de réaliser un certain nombre d’action clé tels que l’enregistrement de tous les salariés, des clients, etc… mais aussi certain point sur l’aide a la gestion de l’entreprise. 

La réalisation de cette application devait être réaliser en C#. Ce dossier comprend la réalisation de 3 modules vous pourrez trouver ci-dessous l'expliquation de ses modules.

Module Client :
L’outil doit pouvoir permettre d’entrer, supprimer ou modifier un nouveau Client depuis la console ou depuis un fichier 
Il faut à tout moment pouvoir afficher l’ensemble des Clients selon plusieurs critères : (successivement ou simultanément) 
- Par ordre alphabétique 
- Par ville 
- Par Montant des achats cumulé, ce qui permettra de connaître les meilleurs clients 

Module Salarié :
Pour faciliter la simulation, il vous est demandé de pouvoir afficher l’organigramme de manière efficace en vous basant 
sur une construction d’arbre n-aire
Il faut, par ailleurs, pouvoir embaucher ou licencier un salarié et l’inclure ou l’exclure de l’organigramme. 

Module Commande :
Pour faciliter la simulation, il vous est demandé de pouvoir partir d’une situation initiale où aucune commande n’existe 
et au fil de l’utilisation de l’application sauvegarder les commandes effectuées afin de créer une base qui s’auto-enrichit. 
Il faut donc pouvoir créer une nouvelle commande ou la modifier et simuler ses différentes étapes 
Une commande ne peut être réalisée que si le client existe dans la base ou sinon il faut le créer. Une commande doit mettre 
en jeu un parcours entre une ville de départ et une ville d’arrivée et établir le chemin le plus court pour la date déterminée. 
Il faut ensuite assigner un chauffeur évidemment disponible. 
Les tarifs sont fonction du km parcouru et du tarif horaire du chauffeur qui peut varier en fonction de son ancienneté. 

Il faut pouvoir à tout moment :
 - Calculer le prix d’une commande et l’afficher moyennant son numéro 
 - Déterminer le chemin que devra parcourir le chauffeur afin de lui donner son plan de route. 
