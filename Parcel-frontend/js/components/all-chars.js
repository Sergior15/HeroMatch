export default function AllChars(game){

    return `
    <div class = "char-all">
    ${game.character.map (singlechar => {
        return `
        <div class='char-all-box'>
            <div class='allChar'>
            <div class='imageAndName'>
            <img class='single-char' src=${singlechar.smallImage}>            
            <p class='single-char-name'>${singlechar.name}</p>
            <input class='gameid' value=${singlechar.gameId} type='hidden'>
            <input class='apiLocation' value=${singlechar.apiLocation} type='hidden'>
            <input class='video' value=${singlechar.video} type = 'hidden'>
            <input class='image' value=${singlechar.image} type ='hidden'>
            </div>
            </div>
        </div>

        `
    }).join("")}
    </div>
    
    `

}

