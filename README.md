# Cronometro
Con este ejemplo trato de recrear el error, es simple pero  muestra como el **Timer()** se ralentiza. 
Las pruebas realizadas consisten en lo siguiente. Con un cronómetro controloremos si el **timer funciona bien**. 
El timer esta programado para que cada segundo realice una accion. En este caso la accion es simular un cronómetro.
Ejecutamos al mismo tiempo los cronómetros y **cambiamos de pestaña del navegador** un Ejemplo seria entrar a Facebook mientras que nuestros cronometros se estan ejecutando,
a los 10 minutos notaremos que hay una diferencia con los cronometros. El que fue creado en **Blazor esta atrasado**. 
Sin embargo, ambos cronómetros iniciaron al mismo tiempo . El **cronómetro creado en Blazor se ralentizo** solo por el hecho de entrar a otra pagina,
este problema se da a notar bastante cuando la aplicacion crece, una observacion es la siguiente. 
Todo funciona bien si te quedas observado el cronómetro creado en Blazor sin cambiar de pestaña .
Para mas detalles del error :
https://www.linkedin.com/in/percy-luis-leon-lucas/
