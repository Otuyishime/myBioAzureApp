-- Add the projects table
CREATE TABLE PROJECTS
(
	PROJ_ID int identity(1,1),
	PROJ_TITLE varchar(300) NOT NULL,
	PROJ_DESCRIPTION varchar(2000) NOT NULL,
	PRIMARY KEY (PROJ_ID)
);

INSERT INTO PROJECTS (PROJ_TITLE, PROJ_DESCRIPTION) 
VALUES
(
	'iCollab Content Sharing', 
	'Freelancer is a free bootstrap theme created by Start Bootstrap. 
	The download includes the complete source files including HTML, CSS, 
	and JavaScript as well as optional LESS stylesheets for easy customization. 
	Whether you are a student looking to showcase your work, a professional 
	looking to attract clients, or a graphic artist looking to share your projects,
	 this template is the perfect starting point!'
);

INSERT INTO PROJECTS (PROJ_TITLE, PROJ_DESCRIPTION) 
VALUES
(
	'iKaze Project', 
	'Freelancer is a free bootstrap theme created by Start Bootstrap. 
	The download includes the complete source files including HTML, CSS, 
	and JavaScript as well as optional LESS stylesheets for easy customization. 
	Whether you are a student looking to showcase your work, a professional 
	looking to attract clients, or a graphic artist looking to share your projects,
	 this template is the perfect starting point!'
);

SELECT * FROM PROJECTS