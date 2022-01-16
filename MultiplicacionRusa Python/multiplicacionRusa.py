from timeit import default_timer as timer

a = input("Ingrese el primer numero: ")
b = input("Ingrese el segundo numero: ")

inicio = timer()
menor = int(min(a, b))
mayor = int(max(a, b))
resultado = 0

while menor > 0:
    if menor % 2 == 1:
        resultado += mayor
    menor //= 2
    mayor *= 2
print("El resultado es: ", resultado)
fin = timer()

print("Tiempo de ejecucion:", (fin - inicio) * 1000, "milisegundos")
