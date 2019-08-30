import apiActions from '../api/api-actions'
import SingleChar from './singlechar'
export default function SingleCharHandler(){
    if(event.target.classList.contains('single-char')){
        let gameId = event.target.parentElement.querySelector('.gameid').value
        let video = event.target.parentElement.querySelector('.video').value
        let image = event.target.parentElement.querySelector('.image').value
        let apiLocation = event.target.parentElement.querySelector('.apiLocation').value
        if(gameId == 2){
            apiActions.getRequest(apiLocation, char => {
                console.log(char)
                let chardata = Object.values(char.data)[0]
                console.log(chardata)
                document.querySelector('#quiz').innerHTML = SingleChar(chardata, gameId,video,image);
            })
        }
        else{
            apiActions.getRequest(apiLocation, char =>{
                document.querySelector('#quiz').innerHTML = SingleChar(char, gameId,video,image);
            })
        }
    }
}
