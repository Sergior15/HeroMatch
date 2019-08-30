export default function SingleChar(char, gameid,video,image){
    if(gameid == 1)
    return `
    <div class='single-char-container'>
        <div class='ow_textbox'>
        <img class='ow_single-char' src = ${image}>
        <div class='ow_lore'>
        <h3>${char.name}</h3>
        <p>${char.description}</p>
        </div>
        </div>
        <div class='ow_abilities'>
            ${char.abilities.map(ability=>{
                return `
                <div class='single-ability'>
                <h4>${ability.name}</h4>
                <p>${ability.description}</p>
                </div>
                `
            }).join("")}
        </div>
    </div>
    `
    else if(gameid == 2)
    return `
    <div class='single-char-container'>
        <img class='lol_single-char' src = ${image}>
        <div class='lore'>
        <h3>${char.name}, ${char.title}</h3>
        <p>${char.lore}</p>
        </div>
        <div class='abilities'>
            ${char.spells.map(spell=> {
                    return `
                    <div class='single-ability'>
                    <h4>${spell.name}</h4>
                    <p>${spell.description}</p>
                    <br/>
                    </div>
                    `

    }).join("")}
        </div>
        <iframe width="560" height="315" src="https://www.youtube.com/embed/${video}" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
    </div>
    `
}