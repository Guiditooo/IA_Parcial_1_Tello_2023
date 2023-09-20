# IA_Parcial_1_Tello_2023

- [ ] Crear un mapa de superficie finita con ancho y alto modificable por el usuario antes de su creación.

- [ ] El mapa debe estar poblado por nodos equidistantes en grilla cuadrada, la distancia entre nodos también debe ser modificable por el usuario antes de la creación del mapa.

- [ ] El mapa cuenta con minas de oro dispersas en nodos aleatorios al momentos de generarse el mapa, la cantidad es modificable por el usuario.

- [ ] En un punto del mapa hay un “Centro urbano” que es el encargado de generar dos tipos de agentes, “aldeanos” y “caravanas”.

- [ ] Cada uno de los tipos de agentes es capaz de navegar o no por los distintos tipos de nodos del mapa, y con costos de atravesarlos diferentes.

- [ ] Cada tipo de agente tiene calculado su propio Diagrama de Voronoi (o polígono de thiessen) para saber cual es la mina de oro más cercana desde cualquier punto del mapa.

- [ ] Al iniciar la simulación, los aldeanos van a recolectar oro a la mina más cercana, extraen uno de oro cada cierta cantidad de tiempo, y cada tres de oro extraído necesitan comer una unidad de comida para poder seguir trabajando.

- [ ] La comida es llevada por las caravanas desde el centro urbano hasta las minas a razón de diez por viaje.

- [ ] En el momento de que el aldeano tenga 15 de oro en su inventario, regresará al centro urbano a depositarlo.

- [ ] Si un aldeano no puede comer, esperará a que haya comida disponible para seguir trabajando.

- [ ] En caso de que la mina en la que el aldeano estaba trabajando o a la que se estaba dirigiendo se agote irá a la mina que esté más cercana a su posición.

- [ ] Las caravanas sólo proveen de comida a las minas donde un aldeano está trabajando.

- [ ] En cualquier momento puede sonar una alarma (un botón en la UI) que hace que todos los agentes abandonen lo que están haciendo y regresen a refugiarse al centro urbano.

- [ ] En cualquier momento, si la alarma está dada, se puede cancelar la alarma (con otro botón en la UI) que haga que:

	- [ ] Los agentes que estaban dentro del centro urbano salgan y regresen al trabajo.

	- [ ] Los que no habían llegado a refugiarse aún retoman sus labores.

- [ ] En caso de que una de las minas de oro se agote, se recalculan los Diagramas de Voronoi (o polígonos de thiessen).

- [ ] En caso de que la transitabilidad del terreno se modifique, se recalculan los Diagramas de Voronoi (o polígonos de thiessen) solo a los agentes que esta modificación les afecte.

- [ ] Cada agente tiene su propio FSM para cumplir sus labores.

- [ ] El FSM de cada agente se actualiza en multi-threading.

- [ ] El cálculo de caminos se hace siguiendo el algoritmo de A-Star.

- [ ] Si varios agentes del mismo tipo se están moviendo cerca, evitan superponerse utilizando el algoritmo de Flocking*.