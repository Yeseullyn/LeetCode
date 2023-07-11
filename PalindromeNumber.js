/**
 * 9. Palindrome Number
 * Given an integer x, return true if x is a palindrome,
 * and false otherwise.
 * @param {number} x
 * @return {boolean}
 */
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

console.log(isPalindrome(121));
console.log(isPalindrome(-121));
console.log(isPalindrome(10));