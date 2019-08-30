export default function TakeQuiz(games){
    return `
    <div class='games'>
    <h1 class='choose'>Choose a Game</h1>
    <div class='main-flex'>
        ${games.map(game => {
        return `
            <div class='select'>
                <img class='select-game' src="${game.image}">
                <input class='select-game__id' type='hidden' value="${game.gameId}">
            </div>
            `;
        })
        .join("")}
    </div>
    </div>        
    `
}