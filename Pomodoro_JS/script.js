// function formatTimeLeft(time) {
//   // The largest round integer less than or equal to the result of the time divided by 60. Want timer to be 45 minutes though!

//   const minutes = Math.floor(time / 60);

//   // seconds are the remainder of the time divided by 60 (modulus operator)
//   let seconds = time % 60;

//   // if the value of the seconds is less than 10, then display
//   if (seconds < 10) {
//     seconds = `0${seconds}`;
//   }

//   // the output in MM:SS format
//   return `${minutes}:${seconds}`;
// }

// // Start with an initial value of 20 seconds

// const TIME_LIMIT = 20;

// // Initially, no time has passed, but this will count up
// // and substract from the TIME_LIMIT

// let timePassed = 0;
// let timeLeft = TIME_LIMIT;