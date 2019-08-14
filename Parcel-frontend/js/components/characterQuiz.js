export default function CharacterQuiz(gameId){
return `
<div class="entireQuestionBox">
    <header id="quizHeader">
     <h1>Find Your Hero</h1>
    </header>


    <div class=Question_Container>
        <button class="Question_Head">
            <h2>What's your level of experience with video games?</h2>
        </button>
        <div class=Question_Choices value='1'>
            <button class='quiz-button diffOption' value='1'><img src="https://i.imgur.com/hYqq7Yd.png">&nbsp; I have little to no experience with video games.</button>
            <button class='quiz-button diffOption' value='2'><img src="https://i.imgur.com/snZDf0J.png">&nbsp; I have some experience with video games.</button>
            <button class='quiz-button diffOption' value='3'><img src="https://i.imgur.com/6DSSOKK.png">&nbsp; I have a lot of experience with video games.</button>
        </div>
    </div>

    <div class=Question_Container>
        <div class=Question_Head>
            <h2>Which of these roles would be most appealing to you?</h2>
        </div>
        <div class=Question_Choices value='2'>
            <button class='quiz-button roleOption' value='1'><img src='https://i.imgur.com/fGNN8j1.png'>&nbsp; A lead role, where I decide the direction the team is headed.</button>
            <button class='quiz-button roleOption' value='2'><img src="https://i.imgur.com/SERrZIq.png">&nbsp; A damage role, where I focus on taking down a specific enemy.</button>
            <button class='quiz-button roleOption' value='3'><img src="https://i.imgur.com/noSGFOw.png">&nbsp; A supportive role, where I help others perform their roles optimally.</button>
        </div>
    </div>

    <div class=Question_Container >
        <div class=Question_Head>
            <h2>Within this role, which of these styles is most appealing?</h2>
        </div>
        <div class=Question_Choices id='subroleOptions' value='3'>
            <p>Please select a role before answering this question.</p>
            </div>
        </div>
        
    <div class=Question_Container id=optional style="display:none">
        </div>
            <div id = "submit">
            <button class='quiz-button submit-button'>Submit</button>
        </div>
    <input id='charquiz_gameId' style='display:none' value = ${gameId}>  
</div>

`
}