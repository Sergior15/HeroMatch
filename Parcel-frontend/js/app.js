import ApiActions from './api/api-actions'
import TakeQuiz from './components/takeQuiz';
import Home from './components/home';
import CharacterQuiz from './components/characterQuiz';
import CharacterResult from './components/characterResult';
import SubroleOptions from './components/subrole-options';
import AllChars from './components/all-chars';
import AestheticOptions from './components/aesthetic-options'
import apiActions from './api/api-actions';
import About from './components/about';
import SingleCharHandler from './components/single-char-handler';
import AllGames from './components/allGames';
import SingleGame from './components/singleGame';

console.log("app.js");

pageBuild();

function pageBuild(){
    home();
    characterQuiz();
    allChars();
    takeQuiz();
    about();
    allGames();
    singleGame();
};

function home(){
    
    const home = document.getElementById('nav_home');
    home.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44399/api/game', home =>{
        
        document.getElementById('quiz').innerHTML = Home(home);
        })
    });

    document.getElementById('quiz').addEventListener('click', function() {
        if(event.target.classList.contains('take-quiz')){
            apiActions.getRequest('https://localhost:44399/api/game', games =>{
            document.getElementById('quiz').innerHTML = TakeQuiz(games);
        });
        }
    })
};

function about(){
    const about = document.getElementById('nav_about');
    about.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44399/api/game', about =>{
            document.getElementById('quiz').innerHTML = About(about);
        })
    } )
}
function allGames(){
    const games = document.getElementById('nav_games');
    games.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44399/api/game', games =>{
        document.getElementById('quiz').innerHTML = AllGames(games);

        })
    });
}

function singleGame(){
    document.getElementById('quiz').addEventListener('click', function(){
        
        if (event.target.classList.contains('gameName')){
            let gameId = event.target.parentElement.querySelector('.game__id').value
            console.log(gameId);
            ApiActions.getRequest('https://localhost:44399/api/game/'
            +gameId, game => {
                document.getElementById('quiz').innerHTML = SingleGame(game);
                
            })
        }           
                
    })
}

function takeQuiz(){
    const quiz = document.getElementById('nav_quiz');
    quiz.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44399/api/game', games =>{
        document.getElementById('quiz').innerHTML = TakeQuiz(games);

        })
    });
    const bodyquiz = document.getElementById('body_quiz');
    bodyquiz.addEventListener('click', function(){
        apiActions.getRequest('https://localhost:44399/api/game', games =>{
        document.getElementById('quiz').innerHTML = TakeQuiz(games);

        })
    });
}

function allChars(){
    document.getElementById('quiz').addEventListener('click', function(){
        let gameId = 0;

        if(event.target.classList.contains('allChar')){
            gameId = event.target.value
            ApiActions.getRequest('https://localhost:44399/api/game/'+ gameId, game => {
                    document.querySelector('#quiz').innerHTML = AllChars(game);
                }
            )
        }

        SingleCharHandler();

    })
        document.getElementById('quiz').addEventListener('click', function(){
            let gameId = 0;
    
            if(event.target.classList.contains('single-game-chars')){
                gameId = event.target.value
                ApiActions.getRequest('https://localhost:44399/api/game/'+ gameId, game => {
                        document.querySelector('#quiz').innerHTML = AllChars(game);
                    }
                )
            }
        })
    }


function characterQuiz(){
    let difficulty = 0;
    let role = 0;
    let subrole = 0;
    let aesthetic = 0;

    document.addEventListener('click', function(){
        if(event.target.classList.contains('select-game')){
            console.log('event')
            let gameId = event.target.parentElement.querySelector('.select-game__id').value
            document.getElementById('quiz').innerHTML = CharacterQuiz(gameId);
            if(gameId == 2){
                document.getElementById('optional').innerHTML= AestheticOptions();
                document.getElementById('optional').style.display="block";
            }
        }
    })
    document.addEventListener('click', function(){
        if(event.target.classList.contains('single-quiz')){
            console.log('event')
            let gameId = event.target.parentElement.querySelector('.single-quiz').value
            document.getElementById('quiz').innerHTML = CharacterQuiz(gameId);
            if(gameId == 2){
                document.getElementById('optional').innerHTML= AestheticOptions();
                document.getElementById('optional').style.display="block";
            }
        }
    })

    document.querySelector('#quiz').addEventListener('click', function(){
        if(event.target.classList.contains('diffOption')){
            difficulty = event.target.value
            console.log(difficulty)
            console.log(role)
            console.log(subrole)
        }

        if(event.target.classList.contains('roleOption')){
            role = event.target.value
            console.log(difficulty)
            console.log(role)
            console.log(subrole)
            document.getElementById('subroleOptions').innerHTML = SubroleOptions(role);
        }
        
        if(event.target.classList.contains('subRoleOption')){
            subrole = event.target.value
            console.log(difficulty)
            console.log(role)
            console.log(subrole)
        }
        if(event.target.classList.contains('aestheticOption')){
            aesthetic = event.target.value
            console.log(difficulty)
            console.log(role)
            console.log(subrole)
            console.log(aesthetic)
        }
        
        

        if(event.target.classList.contains('submit-button')){
            
            difficulty = difficulty
            role = role
            subrole = subrole
            aesthetic = aesthetic
            let gameid = document.getElementById('charquiz_gameId').value
            
            ApiActions.getRequest('https://localhost:44399/api/characters/'
            +gameid+'/'+difficulty +'/'+role+'/'+subrole , characters => {
                document.querySelector('#quiz').innerHTML = CharacterResult(characters, aesthetic);
                
            })
            
        }  
        
    
        // var coll = document.getElementsByClassName("Question_Head");
        // var i;
        // for (i = 0; i < coll.length; i++) {
        // coll[i].addEventListener("click", function() {
        // this.classList.toggle("active");
        // var content = this.nextElementSibling;
        // if (content.style.maxHeight) {
        //     content.style.maxHeight = null;
        // } else {
        //     content.style.maxHeight = content.scrollHeight + "px";
        // }
        // });
        // }
    })
    document.querySelector("#quiz").addEventListener("click", function(){ 
        if(event.target.classList.contains('switch-game')){
            console.log(gameid)
            difficulty = difficulty
            role = role
            subrole = subrole
            aesthetic = aesthetic
            let gameid = document.querySelector('.gameid').value

            if(gameid == 2){
                gameid = 1

                ApiActions.getRequest('https://localhost:44399/api/characters/'
                +gameid+'/'+difficulty +'/'+role+'/'+subrole , characters => {
                    document.querySelector('#quiz').innerHTML = CharacterResult(characters, aesthetic);
                })
            }
            else{
                gameid = 2

                ApiActions.getRequest('https://localhost:44399/api/characters/'
                +gameid+'/'+difficulty +'/'+role+'/'+subrole , characters => {
                    document.querySelector('#quiz').innerHTML = CharacterResult(characters, aesthetic);
                })
                
            }
        }
        })
}


