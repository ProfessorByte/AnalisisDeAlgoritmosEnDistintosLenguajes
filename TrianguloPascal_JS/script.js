console.time('loop');

var n = 3000; //número de filas  
var texto = '';

var A = new Array(n);
var B = new Array(n);

for (var k = 0; k <= n; k++) {
    A[k] = 0;
}

A[1] = 1;
texto = A[1] + '<br>';
for (var i = 2; i <= n; i++) {
    for (var j = 1; j <= i; j++) {
        B[j] = A[j - 1] + A[j];
        texto += B[j] + " ";
    }
    for (j = 1; j <= i; j++) {
        A[j] = B[j];
    }
    texto += "<br>";
}
document.getElementById("resultado").innerHTML = texto;

console.timeEnd('loop');
