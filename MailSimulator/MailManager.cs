using System.Net.Mail;
using System.Text;

namespace MailSimulator;

static class MailManager
{
    public static List<User> ListOfUsers { get; private set; } = new List<User>();
    public static List<string> ListOfObjects { get; private set; } = new List<string>();

    public static List<string> ListOfMessages { get; private set; } = new List<string>();
    public static List<Attachment> ListOfAttachments { get; private set; } = new List<Attachment>();

    static MailManager()
    {
        User user1 = new User("john.doe@example.com");
        User user2 = new User("emily.smith@example.com");
        User user3 = new User("david.jones@example.com");
        User user4 = new User("sarah.wilson@example.com");
        User user5 = new User("michael.brown@example.com");
        User user6 = new User("laura.jackson@example.com");
        User user7 = new User("robert.anderson@example.com");
        User user8 = new User("jennifer.white@example.com");
        User user9 = new User("matthew.taylor@example.com");
        User user10 = new User("lisa.thomas@example.com");
        User user11 = new User("james.wilson@example.com");
        User user12 = new User("mary.harris@example.com");
        User user13 = new User("daniel.martin@example.com");
        User user14 = new User("jessica.moore@example.com");
        User user15 = new User("christopher.lee@example.com");
        User user16 = new User("ashley.allen@example.com");
        User user17 = new User("william.carter@example.com");
        User user18 = new User("amanda.hall@example.com");
        User user19 = new User("jason.green@example.com");
        User user20 = new User("karen.murphy@example.com");
        ListOfUsers.Add(user1);
        ListOfUsers.Add(user2);
        ListOfUsers.Add(user3);
        ListOfUsers.Add(user4);
        ListOfUsers.Add(user5);
        ListOfUsers.Add(user6);
        ListOfUsers.Add(user7);
        ListOfUsers.Add(user8);
        ListOfUsers.Add(user9);
        ListOfUsers.Add(user10);
        ListOfUsers.Add(user11);
        ListOfUsers.Add(user12);
        ListOfUsers.Add(user13);
        ListOfUsers.Add(user14);
        ListOfUsers.Add(user15);
        ListOfUsers.Add(user16);
        ListOfUsers.Add(user17);
        ListOfUsers.Add(user18);
        ListOfUsers.Add(user19);
        ListOfUsers.Add(user20);
       ListOfMessages.Add("Bonjour ! Comment puis-je vous aider aujourd'hui ?");
        ListOfMessages.Add("Salut ! Besoin d'assistance ? Je suis là pour vous !");
        ListOfMessages.Add("Bonjour ! N'hésitez pas à me poser vos questions.");
        ListOfMessages.Add("Salut ! Prêt à résoudre tous vos problèmes.");
        ListOfMessages.Add("Bonjour ! Comment puis-je rendre votre journée meilleure ?");
        ListOfMessages.Add("Salut ! Qu'est-ce qui vous tracasse ?");
        ListOfMessages.Add("Bonjour ! Prêt à vous aider dans tout ce dont vous avez besoin.");
        ListOfMessages.Add("Salut ! Besoin d'une main secourable ? Je suis là !");
        ListOfMessages.Add("Bonjour ! Comment puis-je faciliter votre journée ?");
        ListOfMessages.Add("Salut ! Besoin d'une solution rapide ? Je suis là pour ça !");
        ListOfMessages.Add("Bonjour ! Que puis-je faire pour vous rendre service aujourd'hui ?");
        ListOfMessages.Add("Salut ! Prêt à résoudre vos dilemmes en un clin d'œil.");
        ListOfMessages.Add("Bonjour ! Besoin de conseils ? Je suis à votre disposition !");
        ListOfMessages.Add("Salut ! Comment puis-je illuminer votre journée ?");
        ListOfMessages.Add("Bonjour ! N'hésitez pas à me demander de l'aide.");
        ListOfMessages.Add("Salut ! Je suis là pour rendre les choses simples.");
        ListOfMessages.Add("Bonjour ! Que puis-je faire pour vous aujourd'hui ?");
        ListOfMessages.Add("Salut ! Besoin d'une réponse rapide ? Je suis là pour ça !");
        ListOfMessages.Add("Bonjour ! Prêt à être votre super assistant.");
        ListOfMessages.Add("Salut ! Comment puis-je embellir votre journée ?");
        ListOfMessages.Add("Bonjour ! N'hésitez pas à me solliciter si besoin.");
        ListOfMessages.Add("Salut ! Besoin de résoudre un problème ? Je suis là pour vous aider !");
        ListOfMessages.Add("Bonjour ! Je suis là pour vous soutenir.");
        ListOfMessages.Add("Salut ! Comment puis-je rendre votre vie un peu plus facile ?");
        ListOfMessages.Add("Bonjour ! Besoin d'un coup de main ? Je suis là pour ça !");
        ListOfMessages.Add("Salut ! Prêt à faire de votre journée une réussite !");
        ListOfMessages.Add("Bonjour ! Comment puis-je vous rendre service aujourd'hui ?");
        ListOfMessages.Add("Salut ! Besoin d'une solution rapide ? Je suis là pour ça !");
        ListOfMessages.Add("Bonjour ! N'hésitez pas à me demander de l'aide quand vous en avez besoin.");
        ListOfMessages.Add("Salut ! Je suis là pour rendre votre journée meilleure.");
        ListOfMessages.Add("Bonjour ! Que puis-je faire pour vous aider aujourd'hui ?");
        ListOfMessages.Add("Salut ! Besoin de conseils ? Je suis à votre écoute !");
        ListOfMessages.Add("Bonjour ! Prêt à résoudre vos problèmes avec efficacité.");
        ListOfMessages.Add("Salut ! Comment puis-je vous aider à réussir aujourd'hui ?");
        ListOfMessages.Add("Bonjour ! Besoin d'une réponse rapide ? Je suis là pour vous !");
        ListOfMessages.Add("Salut ! Je suis là pour faciliter votre vie.");
        ListOfMessages.Add("Cher [Nom],\n\nJ'espère que cette journée vous trouve en pleine forme ! Je tenais à vous remercier pour votre récente collaboration. Votre travail a été extrêmement précieux et nous avons hâte de poursuivre cette collaboration fructueuse. N'hésitez pas à me contacter si vous avez des questions ou des préoccupations. Au plaisir de travailler à nouveau ensemble très bientôt !\n\nCordialement,\n[Votre Nom]");
        ListOfMessages.Add("Chère [Nom],\n\nJe vous écris pour vous informer des dernières mises à jour concernant notre projet en cours. Nous avons accompli d'énormes progrès et je voulais partager avec vous les détails de nos avancées. Veuillez trouver ci-joint un résumé des principales étapes atteintes jusqu'à présent. N'hésitez pas à me faire part de vos commentaires ou suggestions.\n\nCordialement,\n[Votre Nom]");
        ListOfMessages.Add("Bonjour [Nom],\n\nJe tiens à vous remercier pour votre récente demande d'informations. Nous avons bien reçu votre demande et nous travaillons activement pour vous fournir les détails demandés dans les plus brefs délais. Je reviendrai vers vous dès que j'aurai les informations nécessaires. En attendant, n'hésitez pas à me contacter si vous avez des questions supplémentaires.\n\nCordialement,\n[Votre Nom]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous sommes ravis de vous annoncer que votre commande a été expédiée aujourd'hui. Vous devriez la recevoir dans les prochains jours. Veuillez trouver ci-joint le numéro de suivi pour suivre l'état de votre livraison. Si vous avez des questions ou des préoccupations, n'hésitez pas à nous contacter. Nous sommes là pour vous aider.\n\nCordialement,\n[L'équipe de support]");
        ListOfMessages.Add("Bonjour [Nom],\n\nJe tenais à vous informer que notre prochaine réunion a été fixée au [date] à [heure]. Veuillez prendre note de cet horaire dans votre agenda. Si vous avez des points spécifiques que vous souhaitez aborder lors de cette réunion, n'hésitez pas à me les faire parvenir à l'avance. Je vous remercie et je suis impatient de discuter avec vous lors de notre rencontre.\n\nCordialement,\n[Votre Nom]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nJe vous écris pour vous informer que nous avons bien reçu votre paiement pour la facture numéro [numéro de facture]. Je vous remercie pour votre ponctualité. Si vous avez des questions concernant cette transaction, n'hésitez pas à me contacter. Nous restons à votre disposition pour toute assistance supplémentaire.\n\nCordialement,\n[Votre Nom]");
        ListOfMessages.Add("Bonjour [Nom],\n\nJe vous adresse ce message pour vous annoncer que nous organisons un événement spécial le [date]. Nous serions honorés de votre présence. Veuillez trouver ci-joint une invitation formelle avec tous les détails de l'événement. Nous espérons vous voir parmi nous pour partager ce moment mémorable.\n\nCordialement,\n[L'équipe organisatrice]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous avons le plaisir de vous informer que votre demande de réservation a été confirmée avec succès. Veuillez trouver ci-joint les détails de votre réservation. Si vous avez besoin de modifier quoi que ce soit ou si vous avez des questions, n'hésitez pas à nous contacter. Nous vous souhaitons un agréable séjour !\n\nCordialement,\n[L'équipe de réservation]");
        ListOfMessages.Add("Bonjour [Nom],\n\nJe tenais à vous remercier personnellement pour votre dévouement et votre travail acharné au sein de notre équipe. Votre contribution est inestimable et nous ne pourrions pas atteindre nos objectifs sans vous. Je vous remercie sincèrement pour votre engagement continu et votre passion pour votre travail.\n\nCordialement,\n[Votre Nom]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous avons le plaisir de vous annoncer que vous avez été sélectionné(e) pour participer à notre programme de fidélité. Félicitations ! Veuillez trouver ci-joint toutes les informations nécessaires sur les avantages et les privilèges dont vous bénéficierez en tant que membre. Nous espérons que vous apprécierez les avantages de ce programme.\n\nCordialement,\n[L'équipe de fidélisation]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous vous informons que votre abonnement à notre service a expiré. Pour continuer à bénéficier de nos services, veuillez renouveler votre abonnement dès que possible. Si vous avez des questions ou des préoccupations, n'hésitez pas à nous contacter. Nous sommes là pour vous aider.\n\nCordialement,\n[L'équipe de support]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nJe vous écris pour vous informer que nous avons bien reçu votre demande de renseignements concernant nos produits. Veuillez trouver ci-joint notre catalogue avec toutes les informations détaillées sur nos produits. Si vous avez des questions supplémentaires ou si vous souhaitez passer une commande, n'hésitez pas à nous contacter.\n\nCordialement,\n[L'équipe de vente]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous vous remercions d'avoir choisi notre entreprise pour répondre à vos besoins. Nous sommes honorés de votre confiance et nous nous engageons à vous fournir un service de qualité supérieure. Si vous avez des questions ou des préoccupations, n'hésitez pas à nous contacter. Nous sommes là pour vous aider.\n\nCordialement,\n[L'équipe de support]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous avons le plaisir de vous informer que votre demande de remboursement a été approuvée. Vous recevrez le montant remboursé sur votre compte dans les prochains jours. Si vous avez des questions concernant ce remboursement, n'hésitez pas à nous contacter. Nous vous remercions pour votre patience et votre compréhension.\n\nCordialement,\n[L'équipe financière]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous vous remercions d'avoir assisté à notre événement récent. Nous espérons que vous avez passé un bon moment et que vous avez trouvé l'événement informatif et enrichissant. Nous attendons avec impatience de vous revoir lors de nos prochains événements. Si vous avez des commentaires ou des suggestions, n'hésitez pas à nous en faire part.\n\nCordialement,\n[L'équipe organisatrice]");
        ListOfMessages.Add("Bonjour [Nom],\n\nJe tenais à vous informer que notre société organise un séminaire exclusif sur [Sujet] le [date] à [lieu]. Nous serions honorés de votre participation à cet événement. Ci-joint, vous trouverez une invitation détaillée avec tous les renseignements nécessaires. Nous espérons vivement vous compter parmi nous !\n\nCordialement,\n[L'équipe organisationnelle]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous vous remercions pour votre récente commande chez [Nom de la société]. Nous tenions à vous informer que votre colis a été expédié aujourd'hui et devrait vous parvenir d'ici quelques jours. Pour suivre l'état de votre livraison, veuillez utiliser le numéro de suivi ci-joint. Si vous avez des questions, n'hésitez pas à nous contacter.\n\nCordialement,\n[L'équipe de service client]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous tenions à vous exprimer toute notre gratitude pour votre engagement continu envers notre entreprise. Votre soutien est précieux pour nous et nous sommes reconnaissants de votre confiance. Nous travaillons sans relâche pour vous offrir un service exceptionnel et nous espérons continuer à vous satisfaire. Merci encore pour votre fidélité.\n\nCordialement,\n[L'équipe de direction]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nJe vous écris pour vous informer que nous avons bien reçu votre demande de rendez-vous. Nous avons le plaisir de vous confirmer que votre rendez-vous est fixé au [date] à [heure]. Si vous avez besoin d'informations supplémentaires ou si vous devez modifier cette date, veuillez nous contacter dès que possible. Nous sommes impatients de vous rencontrer.\n\nCordialement,\n[L'équipe administrative]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous vous informons que votre abonnement à notre service prendra fin le [date]. Pour continuer à bénéficier de nos services, veuillez renouveler votre abonnement avant cette date. Si vous avez des questions sur le processus de renouvellement ou sur nos offres actuelles, n'hésitez pas à nous contacter. Nous sommes là pour vous aider.\n\nCordialement,\n[L'équipe de support]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous sommes ravis de vous annoncer que vous avez été sélectionné(e) pour bénéficier d'une offre spéciale réservée aux clients fidèles. Vous trouverez ci-joint les détails de cette offre exclusive. Profitez-en dès maintenant et n'hésitez pas à nous contacter si vous avez des questions ou des préoccupations. Merci pour votre fidélité.\n\nCordialement,\n[L'équipe marketing]");
        ListOfMessages.Add("Bonjour [Nom],\n\nJe vous adresse ce message pour vous informer que notre société organise une journée portes ouvertes le [date] à [lieu]. Nous serions ravis de vous accueillir pour découvrir nos installations et en apprendre davantage sur nos services. Veuillez trouver ci-joint une invitation détaillée. Nous espérons vous voir parmi nous !\n\nCordialement,\n[L'équipe organisationnelle]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous tenions à vous remercier pour votre récente participation à notre sondage de satisfaction. Vos commentaires sont extrêmement précieux pour nous et nous aideront à améliorer nos services. Nous vous remercions de prendre le temps de partager votre opinion. Si vous avez des questions ou des préoccupations, n'hésitez pas à nous contacter.\n\nCordialement,\n[L'équipe qualité]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous sommes ravis de vous annoncer que votre candidature pour le poste de [Nom du poste] a été retenue pour la prochaine étape du processus de recrutement. Nous vous contacterons sous peu pour organiser un entretien. En attendant, veuillez trouver ci-joint les informations complémentaires sur le poste et l'entreprise. Nous vous remercions pour l'intérêt que vous portez à notre société.\n\nCordialement,\n[L'équipe de recrutement]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous vous informons que notre entreprise sera fermée pour congés annuels du [date de début] au [date de fin]. Pendant cette période, nos services seront temporairement suspendus. Nous vous prions de bien vouloir nous excuser pour tout inconvénient que cela pourrait causer. Nous serons de retour dès le [date de reprise] et nous vous remercions pour votre compréhension.\n\nCordialement,\n[L'équipe administrative]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous sommes heureux de vous informer que vous avez été sélectionné(e) pour bénéficier d'une remise spéciale en tant que membre de notre programme de fidélité. Profitez dès maintenant de cette offre exclusive !\n\nCordialement,\n[L'équipe de fidélisation]");
        ListOfMessages.Add( "Bonjour [Nom],\n\nNous sommes ravis de vous annoncer que vous êtes le gagnant de notre dernier tirage au sort. Félicitations ! Veuillez nous contacter pour réclamer votre prix.\n\nCordialement,\n[L'équipe marketing]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous tenions à vous remercier pour votre implication dans notre récente campagne caritative. Grâce à votre générosité, nous avons pu aider de nombreuses personnes dans le besoin.\n\nCordialement,\n[L'équipe de responsabilité sociale]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous vous remercions d'avoir assisté à notre événement de lancement. Nous espérons que vous avez apprécié l'expérience et que vous avez trouvé l'événement instructif.\n\nCordialement,\n[L'équipe événementielle]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous vous informons que votre demande de service après-vente a été traitée avec succès. Si vous avez d'autres questions, n'hésitez pas à nous contacter.\n\nCordialement,\n[L'équipe de service après-vente]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous avons le plaisir de vous informer que vous avez été sélectionné(e) pour participer à notre programme de bêta-testeurs. Vous trouverez toutes les informations nécessaires dans le mail suivant.\n\nCordialement,\n[L'équipe de développement]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous sommes désolés de vous informer que votre réservation pour l'événement [Nom de l'événement] a été annulée en raison de circonstances imprévues. Veuillez nous excuser pour tout inconvénient que cela pourrait causer.\n\nCordialement,\n[L'équipe d'organisation]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous vous informons que votre compte utilisateur a été créé avec succès. Vous pouvez maintenant vous connecter en utilisant les identifiants suivants : [Identifiant/Mot de passe].\n\nCordialement,\n[L'équipe technique]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous sommes heureux de vous annoncer que nous avons atteint un nouveau jalon dans notre entreprise. Merci à vous pour votre contribution à cette réussite collective.\n\nCordialement,\n[L'équipe de direction]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous vous remercions pour votre récente demande de partenariat. Nous avons bien reçu votre dossier et nous l'examinons attentivement. Nous reviendrons vers vous dès que possible avec une réponse.\n\nCordialement,\n[L'équipe de développement des affaires]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous tenions à vous informer que votre compte utilisateur a été suspendu en raison d'activités suspectes. Veuillez nous contacter pour résoudre ce problème.\n\nCordialement,\n[L'équipe de sécurité]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous avons le plaisir de vous annoncer le lancement de notre nouvelle application mobile. Téléchargez-la dès maintenant pour profiter de nos services où que vous soyez.\n\nCordialement,\n[L'équipe de développement]");
        ListOfMessages.Add("Cher(e) [Nom],\n\nNous sommes heureux de vous annoncer que vous avez été promu(e) au poste de [Nouveau poste]. Félicitations pour cette promotion bien méritée !\n\nCordialement,\n[L'équipe de direction]");
        ListOfMessages.Add("Bonjour [Nom],\n\nNous tenions à vous informer que nous organisons un webinaire gratuit sur [Sujet] le [date]. Inscrivez-vous dès maintenant pour y participer.\n\nCordialement,\n[L'équipe événementielle]");
        ListOfMessages.Add(
            "Cher(e) [Nom],\n\nNous vous informons que votre demande de remboursement a été traitée avec succès. Vous devriez recevoir le remboursement sur votre compte dans les prochains jours.\n\nCordialement,\n[L'équipe financière]");
            ListOfObjects.Add("Problème technique");
            ListOfObjects.Add("Confirmation d'expédition de commande");
            ListOfObjects.Add("Remerciements pour votre commande");
            ListOfObjects.Add("Invitation à un événement spécial");
            ListOfObjects.Add("Confirmation de rendez-vous");
            ListOfObjects.Add("Renouvellement d'abonnement");
            ListOfObjects.Add("Offre spéciale pour les membres fidèles");
            ListOfObjects.Add("Confirmation de réservation");
            ListOfObjects.Add("Remerciements pour votre travail acharné");
            ListOfObjects.Add("Annonce de fermeture temporaire de l'entreprise");
            ListOfObjects.Add("Notification de remboursement approuvé");
            ListOfObjects.Add("Invitation à une journée portes ouvertes");
            ListOfObjects.Add("Confirmation de réception de paiement");
            ListOfObjects.Add("Notification de participation à un sondage");
            ListOfObjects.Add("Invitation à un séminaire exclusif");
            ListOfObjects.Add("Annonce de lancement d'un nouveau produit");
            ListOfObjects.Add("Réponse à une demande d'informations");
            ListOfObjects.Add("Notification de commande incomplète");
            ListOfObjects.Add("Remerciements pour votre feedback");
            ListOfObjects.Add("Invitation à une conférence");
            ListOfObjects.Add("Notification de livraison retardée");
            ListOfObjects.Add("Confirmation de modification de réservation");
            ListOfObjects.Add("Remerciements pour votre collaboration");
            ListOfObjects.Add("Notification de compte suspendu");
            ListOfObjects.Add("Invitation à une session de formation");
            ListOfObjects.Add("Confirmation de rendez-vous téléphonique");
            ListOfObjects.Add("Remerciements pour votre participation à un événement");
            ListOfObjects.Add("Notification de mise à jour de politique");
            ListOfObjects.Add("Invitation à une soirée de gala");
            ListOfObjects.Add("Confirmation de réception de CV");
            ListOfObjects.Add("Notification de problème de paiement");
            ListOfObjects.Add("Réponse à une réclamation");
            ListOfObjects.Add("Invitation à un déjeuner d'affaires");
            ListOfObjects.Add("Notification de clôture de compte");
            ListOfObjects.Add("Remerciements pour votre loyauté");
            ListOfObjects.Add("Notification de réservation annulée");
            ListOfObjects.Add("Invitation à une séance de networking");
            ListOfObjects.Add("Confirmation de demande de partenariat");
            ListOfObjects.Add("Notification de changement d'adresse");
            ListOfObjects.Add("Réponse à une demande de démo produit");
            ListOfObjects.Add("Invitation à une séance de brainstorming");
            ListOfObjects.Add("Confirmation de réinitialisation de mot de passe");
            ListOfObjects.Add("Notification de garantie expirée");
            ListOfObjects.Add("Réponse à une demande de devis");
            ListOfObjects.Add("Invitation à une exposition");
            ListOfObjects.Add("Confirmation de participation à un focus group");
            ListOfObjects.Add("Notification de problème de connexion");
            ListOfObjects.Add("Réponse à une demande de retour produit");
            ListOfObjects.Add("Invitation à une réunion de travail");
            ListOfAttachments.Add( new Attachment("rapport_trimestriel.pdf"));
            ListOfAttachments.Add( new Attachment("contrat_de_location.docx"));
            ListOfAttachments.Add( new Attachment("presentation_produit.pptx"));
            ListOfAttachments.Add( new Attachment("facture_2024_001.pdf"));
            ListOfAttachments.Add( new Attachment("cv_nom_prenom.doc"));
            ListOfAttachments.Add( new Attachment("plan_strategique_2024.pdf"));
            ListOfAttachments.Add( new Attachment("proposition_commerciale.ppt"));
            ListOfAttachments.Add( new Attachment("liste_de_contacts.xlsx"));
            ListOfAttachments.Add( new Attachment("manuel_utilisateur_v2.0.pdf"));
            ListOfAttachments.Add( new Attachment("budget_annuel_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("portfolio_nom_prenom.pdf"));
            ListOfAttachments.Add( new Attachment("fiche_technique_produit.docx"));
            ListOfAttachments.Add( new Attachment("agenda_semaine_07.xlsx"));
            ListOfAttachments.Add( new Attachment("brochure_promotionnelle.pdf"));
            ListOfAttachments.Add( new Attachment("rapport_audit_final.docx"));
            ListOfAttachments.Add( new Attachment("contrat_de_service.pdf"));
            ListOfAttachments.Add( new Attachment("presentation_equipe.pptx"));
            ListOfAttachments.Add( new Attachment("plan_de_projet_v3.0.docx"));
            ListOfAttachments.Add( new Attachment("bon_de_commande_2024.pdf"));
            ListOfAttachments.Add( new Attachment("cv_nom_prenom_anglais.doc"));
            ListOfAttachments.Add( new Attachment("statistiques_trimestrielles.xlsx"));
            ListOfAttachments.Add( new Attachment("manuel_d_utilisation_v1.5.pdf"));
            ListOfAttachments.Add( new Attachment("proposition_marketing_v2.pptx"));
            ListOfAttachments.Add( new Attachment("liste_de_taches_semaine_07.xlsx"));
            ListOfAttachments.Add( new Attachment("guide_d_utilisateur.pdf"));
            ListOfAttachments.Add( new Attachment("catalogue_produits_2024.docx"));
            ListOfAttachments.Add( new Attachment("planning_annuel_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("rapport_activite_trimestre_1.pdf"));
            ListOfAttachments.Add( new Attachment("contrat_de_prestation_de_service.docx"));
            ListOfAttachments.Add( new Attachment("presentation_entreprise.pptx"));
            ListOfAttachments.Add( new Attachment("note_de_frais_mars_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("cv_directeur_marketing.doc"));
            ListOfAttachments.Add( new Attachment("compte_rendu_reunion_semaine_07.docx"));
            ListOfAttachments.Add( new Attachment("invitation_evenement.pdf"));
            ListOfAttachments.Add( new Attachment("plan_de_formation_v2.0.docx"));
            ListOfAttachments.Add( new Attachment("catalogue_services_2024.pdf"));
            ListOfAttachments.Add( new Attachment("facture_2024_002.pdf"));
            ListOfAttachments.Add( new Attachment("plan_de_communication.pptx"));
            ListOfAttachments.Add( new Attachment("modele_de_contrat.docx"));
            ListOfAttachments.Add( new Attachment("budget_marketing_annuel_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("fiche_projet_2024.docx"));
            ListOfAttachments.Add( new Attachment("cv_nom_prenom_espagnol.doc"));
            ListOfAttachments.Add( new Attachment("guide_utilisateur_v3.0.pdf"));
            ListOfAttachments.Add( new Attachment("presentation_resultats_trimestriels.pptx"));
            ListOfAttachments.Add( new Attachment("proposition_developpement_web.pdf"));
            ListOfAttachments.Add( new Attachment("plan_de_travail_semaine_07.xlsx"));
            ListOfAttachments.Add( new Attachment("brochure_corporate.pdf"));
            ListOfAttachments.Add( new Attachment("rapport_analyse_marche.docx"));
            ListOfAttachments.Add( new Attachment("contrat_de_prestation_informatique.pdf"));
            ListOfAttachments.Add( new Attachment("proposition_partenariat.pptx"));
            ListOfAttachments.Add( new Attachment("catalogue_promotionnel_2024.docx"));
            ListOfAttachments.Add( new Attachment("planning_mensuel_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("rapport_financier_trimestre_1.pdf"));
            ListOfAttachments.Add( new Attachment("contrat_de_travail.docx"));
            ListOfAttachments.Add( new Attachment("cv_nom_prenom_francais.doc"));
            ListOfAttachments.Add( new Attachment("statistiques_ventes_mars_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("manuel_utilisation_logiciel.pdf"));
            ListOfAttachments.Add( new Attachment("presentation_projet_v2.0.pptx"));
            ListOfAttachments.Add( new Attachment("rapport_activite_mois_mars_2024.docx"));
            ListOfAttachments.Add( new Attachment("proposition_formation_interne.pdf"));
            ListOfAttachments.Add( new Attachment("liste_contacts_clients.xlsx"));
            ListOfAttachments.Add( new Attachment("plan_marketing_annuel_2024.docx"));
            ListOfAttachments.Add( new Attachment("facture_2024_003.pdf"));
            ListOfAttachments.Add( new Attachment("presentation_societe.pptx"));
            ListOfAttachments.Add( new Attachment("planification_strategique_v2.0.docx"));
            ListOfAttachments.Add( new Attachment("cv_nom_prenom_allemand.doc"));
            ListOfAttachments.Add( new Attachment("compte_rendu_audit.docx"));
            ListOfAttachments.Add( new Attachment("invitation_conference.pdf"));
            ListOfAttachments.Add( new Attachment("plan_de_formation_v1.0.docx"));
            ListOfAttachments.Add( new Attachment("catalogue_nouveaux_produits_2024.pdf"));
            ListOfAttachments.Add( new Attachment("planning_trimestriel_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("rapport_activite_trimestre_2.pdf"));
            ListOfAttachments.Add( new Attachment("contrat_de_prestation_consulting.docx"));
            ListOfAttachments.Add( new Attachment("proposition_vente_directe.pptx"));
            ListOfAttachments.Add( new Attachment("brochure_services_2024.pdf"));
            ListOfAttachments.Add( new Attachment("rapport_evaluation_performance.docx"));
            ListOfAttachments.Add( new Attachment("contrat_location_saisonniere.doc"));
            ListOfAttachments.Add( new Attachment("cv_nom_prenom_chinois.doc"));
            ListOfAttachments.Add( new Attachment("statistiques_production_mars_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("manuel_utilisation_appareil.pdf"));
            ListOfAttachments.Add( new Attachment("presentation_investisseurs.pptx"));
            ListOfAttachments.Add( new Attachment("proposition_organisation_evenement.pdf"));
            ListOfAttachments.Add( new Attachment("liste_contacts_fournisseurs.xlsx"));
            ListOfAttachments.Add( new Attachment("plan_de_communication_interne.docx"));
            ListOfAttachments.Add( new Attachment("facture_2024_004.pdf"));
            ListOfAttachments.Add( new Attachment("modele_devis.docx"));
            ListOfAttachments.Add( new Attachment("planning_hebdomadaire_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("rapport_activite_mensuel_mars_2024.docx"));
            ListOfAttachments.Add( new Attachment("contrat_maintenance_informatique.pdf"));
            ListOfAttachments.Add( new Attachment("proposition_services_conseil.pptx"));
            ListOfAttachments.Add( new Attachment("brochure_promotion_immobiliere.pdf"));
            ListOfAttachments.Add( new Attachment("rapport_evaluation_performance_trimestre_1.docx"));
            ListOfAttachments.Add( new Attachment("contrat_vente_voiture.doc"));
            ListOfAttachments.Add( new Attachment("cv_nom_prenom_italien.doc"));
            ListOfAttachments.Add( new Attachment("statistiques_financieres_mars_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("manuel_utilisateur_logiciel_v2.0.pdf"));
            ListOfAttachments.Add( new Attachment("presentation_projet_innovation.pptx"));
            ListOfAttachments.Add( new Attachment("proposition_amelioration_processus.pdf"));
            ListOfAttachments.Add( new Attachment("liste_contacts_partenaires.xlsx"));
            ListOfAttachments.Add( new Attachment("plan_de_formation_v3.0.docx"));
            ListOfAttachments.Add( new Attachment("facture_2024_005.pdf"));
            ListOfAttachments.Add( new Attachment("presentation_resultats_annuels.pptx"));
            ListOfAttachments.Add( new Attachment("contrat_prestation_services_web.docx"));
            ListOfAttachments.Add( new Attachment("proposition_organisation_seminaire.pdf"));
            ListOfAttachments.Add( new Attachment("brochure_promotion_hoteliere.pdf"));
            ListOfAttachments.Add( new Attachment("rapport_evaluation_risques.docx"));
            ListOfAttachments.Add( new Attachment("cv_nom_prenom_portugais.doc"));
            ListOfAttachments.Add( new Attachment("statistiques_ventes_trimestre_1_2024.xlsx"));
            ListOfAttachments.Add( new Attachment("manuel_utilisation_logiciel_v3.0.pdf"));
            ListOfAttachments.Add( new Attachment("presentation_strategie_marketing.pptx"));
            ListOfAttachments.Add( new Attachment("proposition_services_informatiques.pdf"));
            ListOfAttachments.Add( new Attachment("liste_contacts_partenaires_commerciaux.xlsx"));
            ListOfAttachments.Add( new Attachment("plan_de_formation_v4.0.docx"));
            ListOfAttachments.Add( new Attachment("facture_2024_006.pdf"));
            GenerateRandomMailsForUsers();
    }

    public static void GenerateRandomMailsForUsers()
    {
        Random random = new Random();
        for (int i = 0; i < 100; i++)
        {
            User randomSender = ListOfUsers[random.Next(ListOfUsers.Count)];
            int randomSizeOfReceiversList = random.Next(ListOfUsers.Count);
            List<User> randomListOfReceivers = new List<User>();
            while (randomListOfReceivers.Count != randomSizeOfReceiversList)
            {
                User randomReceiver = ListOfUsers[random.Next(ListOfUsers.Count)];
                if (!randomListOfReceivers.Contains(randomReceiver))
                    randomListOfReceivers.Add(randomReceiver);
            }
            string randomMailObject = ListOfObjects[random.Next(ListOfObjects.Count)];
            string randomMessage = ListOfMessages[random.Next(ListOfMessages.Count)];
            int randomSizeOfAttachmentsList = random.Next(10);
            List<Attachment> randomListOfAttachments = new List<Attachment>();
            while (randomListOfAttachments.Count != randomSizeOfAttachmentsList)
            {
                randomListOfAttachments.Add(ListOfAttachments[random.Next(ListOfAttachments.Count)]);
            }

            Mail newMail = new Mail(randomSender, randomListOfReceivers, randomMailObject,
                randomMessage, randomListOfAttachments);
            SendMail(newMail);
        }
    }
    

    public static void SendMail(Mail mail)
    {
        mail.Sender!.ListOfMailsSent.Add(mail);
        foreach (User user in mail.Receiver!)
        {
            user.ListOfMailsReceived.Add(mail);
        }
    }
    public static void DisplayAllUsersWithMails()
    {
        foreach (User user in ListOfUsers)
        {
            Console.WriteLine(user);
        }
    }

    public static void DisplayAllUsersAddress()
    {
        foreach (User user in ListOfUsers)
        {
            Console.Clear();
            Console.WriteLine(user.Address);
        }
    }

    public static void DisplayUserMailsReceived(User user)
    {
        
        int index = 1;
        Console.Clear();
        ConsoleColorManager.BackBlackForeGreen();
        Console.WriteLine($"Number of received Mails: {user.ListOfMailsReceived.Count}");
        for (int i = user.ListOfMailsReceived.Count - 1; i >= 0; i--)
        {
            ConsoleColorManager.BackBlackForeBlue();
            Console.Write("➣ {0,-7}", index);
            ConsoleColorManager.BackBlackForeYellow();
            Console.Write("({0:d}) -> ", user.ListOfMailsReceived[i].Date);
            ConsoleColorManager.BackBlackForeMagenta();
            Console.Write("From {0,-40} => ", user.ListOfMailsReceived[i].Sender!.Address);
            ConsoleColorManager.BackBlackForeCyan();
            Console.WriteLine(user.ListOfMailsReceived[i].MessageObject);
            index++;
        }
        ConsoleColorManager.BackBlackForeBlue();
    }
    
    public static void DisplayUserMailsSent(User user)
    {
        
        int index = 1;
        Console.Clear();
        ConsoleColorManager.BackBlackForeGreen();
        Console.WriteLine($"Number of sent Mails: {user.ListOfMailsSent.Count}");
        for (int i = user.ListOfMailsSent.Count - 1; i >= 0; i--)
        {
            ConsoleColorManager.BackBlackForeBlue();
            Console.Write("➣ {0,-7}", index);
            ConsoleColorManager.BackBlackForeYellow();
            Console.Write("({0:d}) -> ", user.ListOfMailsSent[i].Date);
            ConsoleColorManager.BackBlackForeMagenta();
            string receivers = user.ListOfMailsSent[i].Receiver[0].Address + ";...";
            Console.Write("From {0,-40} => ", receivers);
            ConsoleColorManager.BackBlackForeCyan();
            Console.WriteLine(user.ListOfMailsSent[i].MessageObject);
            index++;
        }
        ConsoleColorManager.BackBlackForeBlue();
    }

    public static void SendMail(User sender, List<User> listOfReceivers, string messageObject,
        string message, List<Attachment> attachments)
    {
        Mail newMail = new Mail(sender, listOfReceivers,messageObject, message, attachments);
        foreach (User user in ListOfUsers)
        {
            if(user.Address.Equals(sender.Address))
                user.ListOfMailsReceived.Add(newMail);
            foreach (User receiver in listOfReceivers)
            {
                if(user.Address.Equals(receiver.Address))
                    user.ListOfMailsReceived.Add(newMail);
            }
        }

        Console.WriteLine(newMail);
        Console.WriteLine("Your mail was sent !");
        Thread.Sleep(2000);
    }

    public static void SendMail(User sender)
    {
        Console.Clear();
        List<User> listOfRecipient = CreateListOfRecipient();
        string mailObject = CreateMailObject();
        string mailMessage = CreateMailMessage();
        List<Attachment> listOfAttachments = CreateListOfAttachments();
        SendMail(sender, listOfRecipient, mailObject, mailMessage,listOfAttachments);
    }

    public static List<Attachment> CreateListOfAttachments()
    {
        List<Attachment> listOfAttachments = new List<Attachment>();
        bool isEnoughAttachment = false;
        Console.WriteLine("Do you want to add an attachment ?(\'N\' -> to next step)");
        string? answer = Console.ReadLine();
        if (answer!.Equals("N"))
            isEnoughAttachment = true;
        while (isEnoughAttachment == false)
        {
            string? attachment;
            Console.WriteLine("Please enter the attachment of your mail");
            attachment = Console.ReadLine();  
            listOfAttachments.Add(new Attachment(attachment!));
            Console.WriteLine("Do you want to add another attachment ?\n(\'N\' -> to next step)");
            answer = Console.ReadLine();
            if (answer!.Equals("N"))
                isEnoughAttachment = true;
        }
        return listOfAttachments;
    }

    public static string CreateMailMessage()
    {
        Console.WriteLine("Please enter the object of your e-mail");
        string message = "";
        Console.ReadLine();
        return message;
    }
    public static string CreateMailObject()
    {
        Console.WriteLine("Please enter the object of your e-mail");
        string mailObject = Console.ReadLine();
        return mailObject;
    }

    public static List<User> CreateListOfRecipient()
    {
        List<User> listOfRecipient = new List<User>();
        bool isEnoughRecipient = false;
        while (isEnoughRecipient == false)
        {
            string? address;
            do
            {
                Console.WriteLine("Please enter the mail of your recipient");
                address = Console.ReadLine();  
            } while (!IsValidAddress(address)) ;

            User? receiverUser = ExistingUser(address);
            if(receiverUser != null)
                listOfRecipient.Add(receiverUser);
            else
            {
                receiverUser = CreateAccount(address);
                listOfRecipient.Add(receiverUser!);
            }
            Console.WriteLine("Do you want to add another recipient ?\n(N -> to next step)");
            string? answer = Console.ReadLine();
            if (answer!.Equals("N"))
                isEnoughRecipient = true;
        }

        return listOfRecipient;
    }
    
    public static void AnswerMail(Mail previous, User sender, List<User> listOfReceivers,
        string messageObject, string message, List<Attachment> attachments)
    {
        Mail newMail = new Mail(previous, sender, listOfReceivers,messageObject, message, attachments);
        foreach (User user in ListOfUsers)
        {
            if(user.Address.Equals(sender.Address))
                user.ListOfMailsReceived.Add(newMail);
            foreach (User receiver in listOfReceivers)
            {
                if(user.Address.Equals(receiver.Address))
                    user.ListOfMailsReceived.Add(newMail);
            }
        }
    }

    public static void Conversation(Mail? lastMail)
    {
        while (lastMail != null)
        {
            Console.WriteLine(lastMail.ToString());            
            lastMail = lastMail.Previous;
        }
    }

    public static bool IsValidAddress(string? address)
    {
        if (address == null)
            return false;
        try
        {
            MailAddress unused = new MailAddress(address);
            return true;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e + " Fail to validate e-mail");
            Console.Clear();
            ConsoleColorManager.BackBlackForeRed();
            Console.WriteLine(
                $"\"{address}\" is not a valid e-mail address format => \"name@example.com\"");
            ConsoleColorManager.BackBlackForeBlue();
            return false;
        }
    }

    public static bool IsExistingAddress(string? address)
    {
        if (address == null)
        {
            return false;
        }
        if (ExistingUser(address) != null)
            return true;
        return false;
    }
    public static User? CreateAccount(string? address)
    {
        if (!IsValidAddress(address))
            return null;
        if (IsExistingAddress(address))
        {
            Console.Clear();
            ConsoleColorManager.BackBlackForeRed();
            Console.WriteLine("This address already exist please choice another");
            ConsoleColorManager.BackBlackForeBlue();
            return null;
        }
        User newUser = new User(address!);
        ListOfUsers.Add(newUser);
        return newUser;
    }
    
    public static User? ConnectionToAddress()
    {
        User? userConnection = null;
        Console.Clear();
        while (userConnection == null)
        {
            Console.WriteLine("Please enter your e-mail address");
            string? address = Console.ReadLine();
            if (IsValidAddress(address))
            {
                userConnection = ExistingUser(address);
                if (userConnection == null)
                {
                    userConnection = CreateAccount(address);
                    break;
                }
            }
        }
        return userConnection;
    }
    
    public static User? ExistingUser(string? address)
    {
        foreach (User user in MailManager.ListOfUsers)
        {
            if (user.Address.Equals(address))
                return user;
        }
        return null;
    }

    public static void DisplayInvalidChoice()
    {
        Console.SetCursorPosition(Console.CursorLeft + 5, Console.CursorTop - 1);
        ConsoleColorManager.BackBlackForeRed();
        Console.WriteLine($"Not a valid choice!");
        ConsoleColorManager.BackBlackForeBlue();
    }
}