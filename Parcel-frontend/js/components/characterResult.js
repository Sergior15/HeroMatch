import SingleCharBlurb from './char-results-blurb'
export default function CharacterResult(characters, aesthetic){
    characters.sort(function(a,b){
        if(b.aesthetic == aesthetic){
            return 1
        }
        return a.aesthetic - b.aesthetic
    })
    return `
    <h1 class='result-head' id='result-head'>Your HeroMatch</h1>
    <br />
    <div class = "char-results">
    ${characters.map(character =>{
        if(character.aesthetic == aesthetic && characters.indexOf(character) == 0)
        return `
        <div>
        <div class= "char-single-result">
            <div class='single-char-info'>
            <h2 class='single-char-name'>${character.name}</h2>
            <p class='char-blurb'>${SingleCharBlurb(character.name, character.difficulty, character.role, character.subRole)}</p>
            </div>
            <img class='single-char' src=${character.image}>            
            <input class='gameid' value=${character.gameId} type='hidden'>
            <input class='apiLocation' value=${character.apiLocation} type='hidden'>
            <input class='video' value=${character.video} type = 'hidden'>
            <input class='image' value=${character.image} type ='hidden'>
        </div>
        <h2>Similar Characters</h2>
        </div>
        `
        else
        return `
        <div class='char-other-result'>
            <div class="single-char-group">
                <div class="imgNameOther">
                <img class='single-char' src=${character.smallImage}>                      
                <p class='single-char-name'>${character.name}</p>
                <input class='gameid' value=${character.gameId} type='hidden'>
                <input class='apiLocation' value=${character.apiLocation} type='hidden'>
                <input class='video' value=${character.video} type = 'hidden'>
                <input class='image' value=${character.image} type ='hidden'>
                </div>
            </div>
        </div>
        `   

    }).join("")}
    </div>
    <div class='buttons'>
   
    <a href=#>
        <button value='${characters[0].gameId }' class="allChar quiz-button">View All Characters For This Game</button>
    </a>
    <a href=#>
        <button class='switch-game quiz-button'>View Similar Characters for Another Game</button>
    </a>
   </div>
    `
}