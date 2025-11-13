# Actividad 1B: Ejecución de tutoriales — Juego en 2D  
**Valor:** 20 puntos  
**Unidad II — Ingeniería en Desarrollo y Gestión de Software**

---

## Objetivo
El estudiante practicará los fundamentos de **videojuegos en 2D con Unity**, aplicando conceptos esenciales de física, animación, interacción y diseño de niveles.

---

## Procedimiento

### Paso 1 — Acceso al sitio
Accede al sitio oficial de **Juego de Plataformas 2D** para seguir los tutoriales de creación de videojuegos 2D paso a paso.

---

### Paso 2 — Tutoriales a observar
Sigue los siguientes videos y replica su funcionalidad dentro de tu proyecto Unity:

| N.º | Tema del video        | 🎥 Link del Video                                                                                                      | 📄 Link del PDF                                                                                                     |
|:---:|:----------------------|:----------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------|
| 01  | **Tutorial Parte 1**  | [Ver Video](https://drive.google.com/drive/folders/1bDGwNxNBZLVNE05Yp-NcbU2LmvZ8BZqp?usp=sharing)                     | [PDF](https://docs.google.com/document/d/13rEsPqh3o0lZUc2DjTS7dxxVZMSsZJx8/edit?usp=sharing&ouid=105524615074979124460&rtpof=true&sd=true)                        |
| 02  | **Tutorial Parte 2**  | [Ver Video](https://drive.google.com/file/d/1r_oYYIrYQz_i_rNvQr02UDkJ7ZJMj_Ib/view?usp=sharing)                      | [PDF](https://docs.google.com/document/d/17lPNr3OL_8nUPipB608uWumu_9BarRDk/edit?usp=sharing&ouid=105524615074979124460&rtpof=true&sd=true)                        |
| 03  | **Tutorial Parte 3**  | [Ver Video](https://drive.google.com/file/d/1Fa3uOvUaFuoLqiKUkbMES-bFefp5ESe7/view?usp=sharing)                      | [PDF](https://docs.google.com/document/d/1nM6f7rfhPl22zz89jTR_UA4wB_NVnmzd/edit?usp=sharing&ouid=105524615074979124460&rtpof=true&sd=true)                        |
| 04  | **Tutorial Parte 4**  | [Ver Video](https://drive.google.com/file/d/1rvUZpJDxPz4tCuQ0QSxPON4XdMgmmqsB/view?usp=sharing)                      | [PDF](https://docs.google.com/document/d/1_-xzuEkzqWLflfxlWQ6t9ShR9q6zz2O_/edit?usp=sharing&ouid=105524615074979124460&rtpof=true&sd=true)                        |
| 05  | **Tutorial Parte 5**  | [Ver Video](https://drive.google.com/drive/folders/1bDGwNxNBZLVNE05Yp-NcbU2LmvZ8BZqp?usp=sharing)                     | [PDF](https://drive.google.com/drive/folders/1bDGwNxNBZLVNE05Yp-NcbU2LmvZ8BZqp?usp=sharing)                        |
| 06  | **Tutorial Parte 6**  | [Ver Video](https://drive.google.com/drive/folders/1bDGwNxNBZLVNE05Yp-NcbU2LmvZ8BZqp?usp=sharing)                     | [PDF](https://drive.google.com/drive/folders/1bDGwNxNBZLVNE05Yp-NcbU2LmvZ8BZqp?usp=sharing)                        |



### Desafíos

| N.º | Descripción     | 🎥 Link del Video / Estado                                                                 |
|:---:|:----------------|:-------------------------------------------------------------------------------------------|
| 01  | **Desafío 1**   | Pendiente                                                                          |
| 02  | **Desafío 2**   | [Ver Video](https://drive.google.com/file/d/12N-biuliIuJjLuaIbftS_ba2rt_DLepM/view?usp=sharing) |
| 03  | **Desafío 3**   | Pendiente                                                                         |
| 04  | **Desafío 4**   | Pendiente                                                                                 |


## Autor
**Nombre:** Roberto Alexis Díaz Galindo  
**Carrera:** Ingeniería en Desarrollo y Gestión de Software  
**Institución:** Universidad tecnologica del norte de guanajuato   
**Periodo:** Septiembre - Diciembre  

---

**Recursos adicionales**
- [Unity Learn — 2D Platformer Game Tutorial](https://learn.unity.com/project/2d-platformer-template)  
- [Documentación oficial de Unity](https://docs.unity3d.com/)  
- [Descargar Unity Hub](https://unity.com/download)

---

*“Crea, experimenta y juega con tus propias reglas.”*



























# Actividad 2: Desarrollo de Videojuego 2D o 3D  
**Valor total:** 40 puntos (20 Saber + 20 Saber Hacer)

---

## Proyecto: Calle Segura 
**Tema:** Educación vial mediante minijuegos interactivos.  
**Objetivo:** Enseñar las reglas básicas de tránsito de forma divertida, fomentando la seguridad vial en peatones, ciclistas y conductores.  

### Descripción general  
El videojuego **Calle Segura** busca concientizar sobre la importancia de respetar las normas de tránsito.  
Cada nivel representa un rol distinto dentro del entorno vial: peatón, ciclista, pasajero, conductor y agente de control.  
A través de minijuegos, el jugador aprende las reglas correctas y ve las consecuencias de las decisiones incorrectas.  

---

## Estructura del proyecto  

```
Assets/
 ├── Scenes/
 │   ├── MainMenu.unity
 │   ├── Nivel1_Peaton.unity
 │   ├── Nivel2_Semaforo.unity
 │   ├── Nivel3_Ciclista.unity
 │   ├── Nivel4_Pasajero.unity
 │   ├── Nivel5_Control.unity
 │   └── Nivel6_Final.unity
 ├── Scripts/
 ├── Sprites/
 ├── UI/
 └── Audio/
```

---

## Idea de los niveles

| Nivel | Título | Descripción | Objetivo educativo |
|:--|:--|:--|:--|
| 1 | Peatón Responsable | Evita autos y cruza la calle solo en paso de cebra. | Enseñar cómo cruzar correctamente la calle. |
| 2 | Semáforo Inteligente | Ayuda a controlar el flujo del tráfico cambiando luces. | Comprender el significado de las señales. |
| 3 | Ciclista Seguro | Recolecta cascos y evita peligros. | Promover el uso del casco y respeto al carril bici. |
| 4 | Pasajero Consciente | Elige transporte seguro y sigue normas dentro del vehículo. | Fomentar el respeto y seguridad del pasajero. |
| 5 | Control Vial | Detén infractores y aplica multas. | Mostrar la importancia de las leyes de tránsito. |
| 6 | Final — Ciudad Segura | Combina todo lo aprendido en un escenario libre. | Reforzar todos los conocimientos previos. |

---

## Historia breve  
El jugador llega a la ciudad de **TránsitoVille**, donde el caos reina en las calles.  
Su misión es ayudar a restaurar el orden aprendiendo las normas de cada rol ciudadano.  
A medida que supera niveles, la ciudad se vuelve más segura y ordenada.

---

## Recursos sugeridos  

- **Sprites y fondos:** [itch.io Assets gratuitos](https://itch.io/game-assets/free)  
- **Música y efectos:** [OpenGameArt.org](https://opengameart.org/) / [Freesound.org](https://freesound.org/)  
- **Fuentes educativas:** [Google Fonts](https://fonts.google.com/)  
- **Tutoriales básicos:** [Unity Learn 2D Platformer](https://learn.unity.com/project/2d-platformer-template)

---

## Mecánicas recomendadas  
- Movimiento básico con flechas o `WASD`.  
- Detección de colisiones y recolección de objetos.  
- Sistema de **puntuación** y **vidas**.  
- Pantalla de **menú principal** y **transición entre niveles**.  
- Música ambiental y efectos según la acción.  

---

## Rúbrica de Evaluación — Videojuego Terminado (50 pts)

| Criterio | Excelente (6.25 pts) | Bueno (5 pts) | Aceptable (3.75 pts) | Insuficiente (1–2.5 pts) |
|:--|:--|:--|:--|:--|
| **1. Funcionamiento técnico general** | Juego fluido, sin errores, mecánicas bien implementadas. | Funcional con errores mínimos. | Errores menores que afectan la experiencia. | Fallos graves o no funcional. |
| **2. GUI y menú principal** | Interfaz intuitiva, estética y funcional. | Menú funcional pero mejorable. | Menú básico o poco atractivo. | Menú ausente o sin función clara. |
| **3. Mapa de mundo interactivo** | Transiciones funcionales entre niveles y diseño visual atractivo. | Mapa presente con transiciones básicas. | Interacción limitada o confusa. | Sin mapa o sin función. |
| **4. Sonido y ambientación** | Sonidos coherentes e integrados. | Sonido presente pero limitado. | Sonido básico o repetitivo. | Sin sonido o con errores. |
| **5. Niveles y progresión** | ≥ 3 niveles con progresión clara y dificultad creciente. | 3 niveles funcionales con poca diferencia. | Menos de 3 niveles o sin progresión. | Solo un nivel o sin avance. |
| **6. Línea de vida / salud** | Sistema funcional y coherente. | Presente con detalles menores. | Básico o poco claro. | Ausente o no funcional. |
| **7. Narrativa y objetivos** | Historia clara y misiones bien definidas. | Narrativa presente pero poco desarrollada. | Objetivos sin motivación clara. | Sin historia ni objetivos. |
| **8. Sistema de Score o puntuación** | Score visible y coherente con el gameplay. | Funcional pero mejorable. | Básico o poco claro. | Sin sistema de puntuación o inoperante. |

---

## Autor
**Nombre:** Roberto Alexis Díaz Galindo  
**Carrera:** Ingeniería en Desarrollo y Gestión de Software  
**Institución:** Universidad Tecnológica del Norte de Guanajuato  
**Periodo:** Septiembre - Diciembre  

---

## Recursos adicionales
- [Unity Learn — 2D Platformer Game Tutorial](https://learn.unity.com/project/2d-platformer-template)
- [Documentación oficial de Unity](https://docs.unity3d.com/)
- [Descargar Unity Hub](https://unity.com/download)

---

> **Consejo:** usa una plantilla de GitHub con secciones visuales (badges, capturas y GIFs).  
> Puedes añadir capturas de pantalla de tu juego con:
> ```markdown
> ![Gameplay Screenshot](ruta/a/tu/imagen.png)
> ```

---

*“Crea, experimenta y juega con tus propias reglas.”*












