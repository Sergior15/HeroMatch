import CharResultsSubRole from './char-results-subrole'
export default function CharResultsRole(role, subrole){
    
    if (role == 1){
        return `
        they are well-suited to a leading / tank role,
        ${CharResultsSubRole(role, subrole)}
        `
    }
    else if (role == 2){
        return `
        they are well-suited to a damage-oriented role,
        ${CharResultsSubRole(role, subrole)}
        `
    }
    else if (role ==3){
        return `
        they are well-suited for a supportive role,
        ${CharResultsSubRole(role, subrole)}
        `
    }
}