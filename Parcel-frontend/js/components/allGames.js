export default function AllGames(games){
    return `
    <div class="lotsGames">
    <h1 id="allGames">Games</h1>
    <div class='allGames'>
    
        ${games.map(game => {
        return `
            <div class='gameList'>
                <img class='gameName' src="${game.image}">
                
                <input class='game__id' type='hidden' value="${game.gameId}">
            </div>
            `;
        })
        .join("")}
    </div>
    </div>        
    `
}