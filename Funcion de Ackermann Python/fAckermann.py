from timeit import default_timer as timer

def ackermann(m, n):
    if m == 0:
        return n + 1
    if n == 0:
        return ackermann(m - 1, 1)
    return ackermann(m - 1, ackermann(m, n - 1))

a = int(input("Ingrese el primer numero: "))
b = int(input("Ingrese el segundo numero: "))

inicio = timer()
print(ackermann(a, b))
fin = timer()

print("Tiempo de ejecucion:", (fin - inicio) * 1000, "milisegundos")
