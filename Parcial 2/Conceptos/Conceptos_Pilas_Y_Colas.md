# Estructura de datos lineales Pilas y Colas

Las Pilas (Stacks) y Colas (Queues) son estructuras de datos lineales fundamentales en programación. Aunque se pueden implementar usando estructuras más básicas como arreglos o listas enlazadas, lo que las distingue es la restricción en la forma en que se insertan y eliminan los elementos.
## Pilas (Stacks)

Una **Pila** es una colección ordenada de elementos donde las operaciones de inserción y eliminación ocurren en el mismo extremo, llamado **Tope** (Top) o **Cima**

## 1.1 Principios LIFO (Last-In, First-Out)

Las pilas siguen el principio **LIFO**: Último en entrar, primero en salir.

## 1.2 Operaciones Básicas

Operación | Nombre común |  Descripción |
|---------|--------------|------------|  
**Insertar**| Push|     Agrega un elemento al **Tope** de la pila  
**Eliminar**| Pop| Remueve y devuelve el elemento del **Tope** de la pila  
**Consultar**| Peek | Devuelve el elemento del **Tope** sin eliminarlo  
**Verificar** | isEmpty | Retorna verdadero si la pila no tiene elementos

## 1.3 Aplicaciones comunes 
- Historial de navegación web (botón "Atrás").  
 - Función Deshacer (Undo) en editores de texto.  
 - Pila de llamadas (Call Stack) en la ejecución de programas y recursividad   
 - Evaluación de expresiones (notación prefija/postfija).

# 2 Colas (Queues)

>Una **Cola** es una colección ordenada de ítems donde la inserción de nuevos elementos tiene lugar por un extremo, llamado el **Final** (Rear o Tail), y la eliminación de elementos ocurre por el otro extremo, llamado el **Frente** (Front o Head).

## 2.1 Principio FIFO(First-in,First-Out)

Las colas siguen el principio **FIFO**: Primero en entrar, primero en salir

## 2.2 Operaciones Básicas

Operación | Nombre común |  Descripción |
|---------|--------------|------------|  
**Insertar**| Enqueue|     Agrega un elemento al **Final** de la cola  
**Eliminar**| Dequeue| Remueve y devuelve el elemento al **Frente** de la cola  
**Consultar**| Peek | Devuelve el elemento al **Frente** sin eliminarlo  
**Verificar** | isEmpty | Retorna verdadero si la cola no tiene elementos

## 2.3 Aplicaciones comunes
- Gestión de tareas y procesos en sistemas operativos (colas de procesos).

- Colas de impresión.

- Manejo de paquetes de información en redes.

- Servicios que manejan peticiones en el orden en que llegan.

# 3 Implementación

Tanto las pilas como las colas se pueden implementar utilizando:

- Arreglos (Arrays): Sencillo, pero puede requerir redimensionamiento si se llena. Las colas en arreglos pueden ser circulares para optimizar el espacio.

- Listas Enlazadas (Linked Lists): Más flexible para crecer o decrecer, y es la base de muchas implementaciones comunes.

# Ejemplo conceptual en Python (Usando una lista como Pila)

pila = []

## 1. PUSH (Apilar)
pila.append(10) # [10]
pila.append(20) # [10, 20]
print(f"Pila después de push: {pila}")

## 2. PEEK (Consultar la cima)
if pila:
    print(f"Elemento en la cima (peek): {pila[-1]}")

## 3. POP (Desapilar - LIFO)
if pila:
    elemento = pila.pop()
    print(f"Elemento desapilado: {elemento}") # 20 (el último que entró)
    print(f"Pila después de pop: {pila}")     # [10]

# Aplicaciones:
 - Pila de llamadas a funciones (Call Stack)
 - Botón 'Atrás' en un navegador
 - Función 'Deshacer' (Undo) en software

 from collections import deque

# Ejemplo conceptual en Python (Usando deque como Cola)

cola = deque()

## 1. ENQUEUE (Encolar)
cola.append( 'A' ) # [ 'A' ]   
cola.append( 'B' ) # [ 'A', 'B' ]
print(f"Cola después de enqueue: {cola}")

## 2. PEEK (Consultar el frente)
if cola:  
    print(f"Elemento en el frente (peek): {cola[0]}")

## 3. DEQUEUE (Desencolar - FIFO)
if cola:  
    elemento = cola.popleft()
    print(f"Elemento desencolado: {elemento}") 
     # 'A' (el primero que entró)  
    print(f"Cola después de dequeue: {cola}") # [ 'B' ]

## Aplicaciones:
- Colas de impresión
- Gestión de procesos y tareas en un Sistema Operativo
- Buffer de teclado/mouse