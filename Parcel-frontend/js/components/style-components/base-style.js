export default function BaseStyle(home){
    return `
    <!DOCTYPE html>
    <html lang="en">
    <head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=<1.0>">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Hero Match</title>
    <link rel= "stylesheet" type= "text/css" href="./style.css"> 
    <link href="https://fonts.googleapis.com/css?family=Cinzel|Grenze&display=swap" rel="stylesheet">
</head>
<body>
    <header>
        <h1>Hero Match</h1>
        <span>Find Your Gaming Character</span>   
    </header>
</br>
    <section id="about">
           ${home}
            
        </section>


    <section id="quiz">
        <h2>Take the quiz</h2>
        <button id="quizbutton">Click here to begin quiz</button>
        
    </section>  
  
    <nav>
        <ul>
            <li id = 'nav_home'>Home</li>
            <li id = 'nav_quiz'>Take quiz</li>
            <li id = 'nav_about'>About</li>
            <li id = 'nav_login'>Login</li>
        </ul>   
                                    
    </nav>    

<div id= 'root'></div> 
<script src="./js/app.js"></script>
</body>
</html>
`;
}