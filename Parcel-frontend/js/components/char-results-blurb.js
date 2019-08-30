import CharResultsRole from './char-results-role'
export default function CharResultsBlurb(name, difficulty, role, subrole){
    
    if (difficulty == 1){
        return `
        HeroMatch has selected ${name} for you because they are a low complexity character,
        ${CharResultsRole(role, subrole)}
        `
    }
    else if (difficulty == 2){
        return `
        HeroMatch has selected ${name} for you because they are a moderate complexity character,
        ${CharResultsRole(role, subrole)}
        `
    }
    else if (difficulty ==3){
        return `
        HeroMatch has selected ${name} for you because they are a high complexity character,
        ${CharResultsRole(role, subrole)}
        `
    }

}