---
version: 1.0.0
---

# TP Entregable

- **Universidad**: Universidad Argentina de la Empresa.
- **Carrera**: Licenciatura en Desarrollo de Videojuegos.
- **Materia**: Programación en tiempo real.
- **Alumno**: Graziani Luciano (1222435).

## Consigna

El proyecto consta de una escena 2D en la cual el jugador podrá moverse y realizar 2 verbos (aclarados más adelante). Sobre esta escena, se deben realizar los siguientes ejercicios:

1. El juego debe empezar pausado y esperar hasta que el jugador toque algún input (cualquiera). La pantalla, mientras esté esperando al primer input del jugador, debe tener un sprite negro con opasidad entre el 50% y 80% (número exacto a elección del estudiante) y un texto en inglés que pida al jugador presionar un botón para empezar (el texto puede ser "press X" y aceptar cualquier botón, "press a button to start", "press to start" o alguna varicación de estas frases). Una vez presionado este input, se quitan tanto el texto como el sprite negro y empieza el juego.
2. El nivel debe estar formado por una serie de tilemaps que cubran el escenario. Los mismos deben tener más de una capa y estar correctamente ordenados dentro de Unity. Los tilemaps y el resto de sprites deben tener su orden de dibujado controlado a través de layers y un "order in layer" apropiado. El tilemap debe, cómo mínimo, cubrir el espacio que ocupa la cámara.
3. Debe haber un personaje, que solo sea controlable después de salir de la pantalla del principio (ej 1). El mismo debe poder moverse en el escenario. A parte del movimiento, deben agregarse 2 (dos) "verbos", "acciones" o "mecánicas" al personaje. Estos pudiendo ser:

   - Salto/doble salto (no se pueden saltos infinitos)
   - Disparo.
   - Golpe melee.
   - Empujar bloques/objetos.
   - Levantar bloques/objetos y dejarlos caer o lanzarlos.
   - Salir por un lado de la pantalla y aparecer del otro (como sucede en los niveles del pacman).
   - Alguna variación de las opciones ya mencionadas.

4. Se debe agregar un objeto interactuable. Este puede ser:
   - Un "Dummy" (un objeto con aspecto de enemigo, que no se mueve ni tiene comportamiento, pero reacciona al ser atacado a través de una animación).
   - Un bloque/objeto que se pueda agarrar y soltar/lanzar.
   - Una palanca que abre y cierra una puerta.

## Bitácora

- Aprendizaje de Input Action Asset: https://www.youtube.com/watch?v=ZSP3bFaZm-o
