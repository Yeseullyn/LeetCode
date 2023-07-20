/**
 * 9. Palindrome Number
 * Given an integer x, return true if x is a palindrome,
 * and false otherwise.
 * @param {number} x
 * @return {boolean}
 */

//First solution
var isPalindrome = function(x) {

    //y를 선언하고 x값을 y에 넣는다.
    var y = x;
    
    //y를 스트링으로 변환한다.
    y = y.toString();

    //스트링으로 변환한 y를 split, reverse, join한다.
    y = y.split('').reverse().join('');
    
    //y를 int로 변경해준다.
    y = parseInt(y);

    //x와 y값이 다르면 false를 리턴한다.
    if (x != y)
    {
        return false;
    }
    return true;
};

//Second solution
var isPalindrome = function (x) {

    if (x < 0) {
        return false;
    }
    // Result는 나머지 값을 저장할 숫자 에레이.
    let result = [];

    // y에 x 초기값을 저장해준다.
    let y = x;

    // for문으로 x를 순회한다.
    for (let i = 0; i < y.toString().length; i++) {
        // x(121)를 %10 나누고 나머지 1을 result에 넣는다.
        result[i] = Math.floor(x % 10);
        // x를 10 으로 나누고 값을 다시 x에 저장한다.
        x = Math.floor(x / 10);
    }
        
    // for문으로 result를 순회한다.
    for (let i = 0; i < result.length; i++)
    {
        // x에 result[i] 곱하기 10의 result.length -1 -i 값을 더해준다.
        x += result[i] * 10 ** (result.length -1 -i);
        }
    // y와 x 값이 같으면 true, 다르면 false를 리턴한다.
    return y === x;
};

console.log(isPalindrome(121));
console.log(isPalindrome(-121));
console.log(isPalindrome(10));