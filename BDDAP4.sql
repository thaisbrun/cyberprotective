#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: ARTICLE
#------------------------------------------------------------

CREATE TABLE ARTICLE(
        num_Article       Int  Auto_increment  NOT NULL ,
        titre_Article     Text NOT NULL ,
        chapeau_Article   Text NOT NULL ,
        datePubli_Article Date NOT NULL ,
        prologue_Article  Text NOT NULL ,
        heure_Article     Time NOT NULL ,
        image_Article     Text NOT NULL ,
        nom_Auteur        Text NOT NULL ,
        prenom_Auteur     Text NOT NULL
	,CONSTRAINT ARTICLE_PK PRIMARY KEY (num_Article)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: THEME
#------------------------------------------------------------

CREATE TABLE THEME(
        num_Theme Int  Auto_increment  NOT NULL ,
        nom_Theme Text NOT NULL
	,CONSTRAINT THEME_PK PRIMARY KEY (num_Theme)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: JOURNAL
#------------------------------------------------------------

CREATE TABLE JOURNAL(
        num_Journal Int  Auto_increment  NOT NULL ,
        nom_Journal Text NOT NULL
	,CONSTRAINT JOURNAL_PK PRIMARY KEY (num_Journal)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: MOT CLE
#------------------------------------------------------------

CREATE TABLE MOT_CLE(
        num_MotCle Int  Auto_increment  NOT NULL ,
        nom_MotCle Text NOT NULL
	,CONSTRAINT MOT_CLE_PK PRIMARY KEY (num_MotCle)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: ENTREPRISE
#------------------------------------------------------------

CREATE TABLE ENTREPRISE(
        num_Entreprise       Int  Auto_increment  NOT NULL ,
        nom_Entreprise       Text NOT NULL ,
        ActiveOuPas          Bool NOT NULL ,
        adresseEntreprise    Text NOT NULL ,
        codePostalEntreprise Int NOT NULL ,
        numeroTelEntreprise  Int NOT NULL
	,CONSTRAINT ENTREPRISE_PK PRIMARY KEY (num_Entreprise)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: ADHERENT
#------------------------------------------------------------

CREATE TABLE ADHERENT(
        numAdherent    Text NOT NULL ,
        nomAdherent    Text NOT NULL ,
        prenomAdherent Text NOT NULL ,
        nomEmployeur   Text NOT NULL ,
        mailAdherent   Text NOT NULL ,
        Login          Text NOT NULL ,
        mdp            Text NOT NULL ,
        ActiveOuPas    Bool NOT NULL ,
        num_Entreprise Int NOT NULL
	,CONSTRAINT ADHERENT_PK PRIMARY KEY (numAdherent)

	,CONSTRAINT ADHERENT_ENTREPRISE_FK FOREIGN KEY (num_Entreprise) REFERENCES ENTREPRISE(num_Entreprise)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: SCORE
#------------------------------------------------------------

CREATE TABLE SCORE(
        numScore    Int  Auto_increment  NOT NULL ,
        scoreTest   Int NOT NULL ,
        nomMedaille Text NOT NULL ,
        numAdherent Text NOT NULL
	,CONSTRAINT SCORE_PK PRIMARY KEY (numScore)

	,CONSTRAINT SCORE_ADHERENT_FK FOREIGN KEY (numAdherent) REFERENCES ADHERENT(numAdherent)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: QUESTION
#------------------------------------------------------------

CREATE TABLE QUESTION(
        numQuestion Int  Auto_increment  NOT NULL ,
        nomQuestion Varchar (50) NOT NULL ,
        Prop1       Varchar (100) NOT NULL ,
        Prop2       Varchar (100) NOT NULL ,
        Prop3       Varchar (100) NOT NULL ,
        Prop4       Varchar (100) NOT NULL ,
        boolProp1   Bool NOT NULL ,
        boolProp2   Bool NOT NULL ,
        boolProp3   Bool NOT NULL ,
        boolProp4   Bool NOT NULL
	,CONSTRAINT QUESTION_PK PRIMARY KEY (numQuestion)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: ArticleJournal
#------------------------------------------------------------

CREATE TABLE ArticleJournal(
        num_Journal Int NOT NULL ,
        num_Article Int NOT NULL
	,CONSTRAINT ArticleJournal_PK PRIMARY KEY (num_Journal,num_Article)

	,CONSTRAINT ArticleJournal_JOURNAL_FK FOREIGN KEY (num_Journal) REFERENCES JOURNAL(num_Journal)
	,CONSTRAINT ArticleJournal_ARTICLE0_FK FOREIGN KEY (num_Article) REFERENCES ARTICLE(num_Article)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: ThemeArticle
#------------------------------------------------------------

CREATE TABLE ThemeArticle(
        num_Theme   Int NOT NULL ,
        num_Article Int NOT NULL
	,CONSTRAINT ThemeArticle_PK PRIMARY KEY (num_Theme,num_Article)

	,CONSTRAINT ThemeArticle_THEME_FK FOREIGN KEY (num_Theme) REFERENCES THEME(num_Theme)
	,CONSTRAINT ThemeArticle_ARTICLE0_FK FOREIGN KEY (num_Article) REFERENCES ARTICLE(num_Article)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: MCArticle
#------------------------------------------------------------

CREATE TABLE MCArticle(
        num_MotCle  Int NOT NULL ,
        num_Article Int NOT NULL
	,CONSTRAINT MCArticle_PK PRIMARY KEY (num_MotCle,num_Article)

	,CONSTRAINT MCArticle_MOT_CLE_FK FOREIGN KEY (num_MotCle) REFERENCES MOT_CLE(num_MotCle)
	,CONSTRAINT McArticle_ARTICLE0_FK FOREIGN KEY (num_Article) REFERENCES ARTICLE(num_Article)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: ArticleQuestion
#------------------------------------------------------------

CREATE TABLE ArticleQuestion(
        num_Article Int NOT NULL ,
        numQuestion Int NOT NULL
	,CONSTRAINT ArticleQuestion_PK PRIMARY KEY (num_Article,numQuestion)

	,CONSTRAINT ArticleQuestion_ARTICLE_FK FOREIGN KEY (num_Article) REFERENCES ARTICLE(num_Article)
	,CONSTRAINT ArticleQuestion_QUESTION0_FK FOREIGN KEY (numQuestion) REFERENCES QUESTION(numQuestion)
)ENGINE=InnoDB;

