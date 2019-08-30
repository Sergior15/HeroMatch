export default function CharResultsSubrole(role, subrole){
    
    if (subrole == 1 && role == 1){
        return `
        and they are effective at inhibiting enemy actions.
        `
    }
    else if (subrole == 2 && role == 1){
        return `
        and they are effective at skirmishing with enemies.
        `
    }


    if (subrole == 1 && role == 2){
        return `
        and they are effective at keeping distance and dealing damage.
        `
    }
    else if (subrole == 2 && role == 2){
        return `
        and they are effective at infiltrating and picking off targets.
        `
    }
    else if (subrole == 3 && role == 2){
        return `
        and they are effective at dealing large amounts of damage very quickly.
        `
    }
    

    if (subrole == 1 && role == 3){
        return `
        and they are a fully dedicated support character.
        `
    }
    else if (subrole == 2 && role == 3){
        return `
        and they are effective at supporting others or facing the enemy.
        `
    }
}