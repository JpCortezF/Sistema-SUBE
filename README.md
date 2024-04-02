<h1>Proyecto Integrador SUBE</h1> 

<p>Este proyecto se ha llevado a cabo en C# WinForms, en conjunto con MySQL, y tiene como objetivo simular un sistema de gestión de viajes similar al Sistema Único de Boletos Electrónicos (SUBE) en Argentina.
Este sistema, dividido en dos roles distintos de usuario y administrador, busca proporcionar una experiencia eficiente y segura para los usuarios mientras gestionan sus viajes y tarjetas.

Funcionalidades para el Usuario:
Carga de la SUBE: Facilita la recarga de saldo en la tarjeta SUBE para los usuarios.
Realización de Viajes: Implementa un proceso asincrónico para llevar a cabo los viajes.
Historial de Viajes: Permite a los usuarios revisar su historial de viajes realizados.
Trámite de Tarifas Sociales: Ofrece la posibilidad de solicitar y gestionar tarifas especiales, como descuentos para jubilados, estudiantes, discapacitados, entre otros.
Reporte de Tarjeta: Permite reportar pérdida, robo o rotura de la tarjeta, así como verificar el estado de dichos reportes.

Funcionalidades para el Administrador:
Gestión de Usuarios: Permite al administrador visualizar y administrar todos los usuarios registrados en el sistema.
Trámites de Usuarios: Facilita la gestión de los diferentes trámites generados por los usuarios, brindando la opción de aceptar o rechazar solicitudes.

Todas estas funcionalidades están completamente integradas con una base de datos MySQL, lo que garantiza la persistencia y seguridad de los datos en todo momento.</p>

## Form Principal (Admin o Pasajero)

<a href="https://postimg.cc/Vdv6HdNW" target="_blank">
  <img src="https://i.postimg.cc/15cqXFh2/Form-Principal.png" alt="Formulario Principal" style="width: 400px; height: auto;">
</a>

Al iniciar el programa, nos encontramos con el formulario principal que brinda la opción de ingresar como administrador o pasajero a la aplicación.

## Form Pasajero

<a href="https://postimg.cc/PvxtcRd5" target="_blank">
  <img src="https://i.postimg.cc/4yvmYDMV/Form-Pasajero.png" alt="Formulario Pasajero" style="width: 400px; height: auto;">
</a>

Después de ingresar como pasajero, se abrirá un formulario con tres opciones: "Ingresa a tu cuenta", "Registrarse" y "Comprar SUBE online".

### Registro

<a href="https://postimg.cc/D8SvPHCC" target="_blank">
  <img src="https://i.postimg.cc/nckXptqt/Form-Registro.png" alt="Formulario de Registro" style="width: 400px; height: auto;">
</a>

En el formulario de registro, se solicitan detalles como número de tarjeta, nombre, apellido, DNI, género, email y contraseña.

### Ingreso

<a href="https://postimg.cc/dhdJzdcr" target="_blank">
  <img src="https://i.postimg.cc/4x2nHb8L/Form-Ingreso.png" alt="Formulario de Ingreso" style="width: 400px; height: auto;">
</a>

Para ingresar, completa los campos de DNI y contraseña.

### Compra Online

<a href="https://postimg.cc/phVxh6hJ" target="_blank">
  <img src="https://i.postimg.cc/63nQSsBg/Form-Compra-Sube.png" alt="Formulario Compra SUBE" style="width: 400px; height: auto;">
</a>
<a href="https://postimg.cc/Tp5xDmwF" target="_blank">
  <img src="https://i.postimg.cc/dt4VgjKs/Compra-ONLINE.png" alt="Compra SUBE Online" style="width: 400px; height: auto;">
</a>

Para comprar una tarjeta SUBE online, se ingresa el DNI (solo si ya tienes una cuenta en nuestra aplicación).

## Home

<a href="https://postimg.cc/fJCcY3r7" target="_blank">
  <img src="https://i.postimg.cc/VkQKQn9h/Inicio-Pasajero.png" alt="Inicio Pasajero" style="width: 400px; height: auto;">
</a>

En la página de inicio, encontrarás un menú con las siguientes opciones:

- **Inicio:** Regresa a la página de inicio.
- **Viajar:** Abre un formulario para viajar en transporte público.

<div style="display: flex; margin-bottom: 20px; margin-right: 10px;">
  <a href="https://postimg.cc/LgzLtQhy" target="_blank">
    <img src="https://i.postimg.cc/d3f6KzFK/Gps-Product.gif" alt="Viaja con tu SUBE" style="width: 400px; height: auto;">
  </a>
  <a href="https://postimg.cc/qNhMGS7J" target="_blank">
    <img src="https://i.postimg.cc/L8vYmMK1/Form-Transporte.png" alt="Formulario de Transporte" style="width: 400px; height: auto; margin-right: 10px;">
  </a>
</div>

- **SUBE:**
  - **Mi SUBE:** Accede a información sobre tu tarjeta SUBE y la posibilidad de cargar saldo y acceder a la tarifa social.

<div style="display: flex; margin-bottom: 20px; margin-right: 10px;">
  <a href="https://postimg.cc/Yvhjsjdw" target="_blank">
    <img src="https://i.postimg.cc/wjkJ3mJ3/Form-Sube-Pasajero.png" alt="Formulario SUBE Pasajero" style="width: 400px; height: auto; margin-right: 10px;">
  </a>
  <a href="https://postimg.cc/ZvdVHJXP" target="_blank">
    <img src="https://i.postimg.cc/Wz9C23ny/Carga-Sube.png" alt="Carga SUBE" style="width: 400px; height: auto;">
  </a>
</div>

  - **Viajes:** Visualiza tus viajes realizados.
  - **Tarifa Social:** Inicia un trámite para acceder a la tarifa social y recibir descuentos en los viajes.

<a href="https://postimg.cc/v1Cnz5yj" target="_blank">
  <img src="https://i.postimg.cc/yd8T7TbV/Form-Tramites.png" alt="Formulario Trámites" style="width: 400px; height: auto; margin-bottom: 20px;">
</a>

  - **Dar de Baja:** Da de baja tu tarjeta SUBE por robo, pérdida o rotura.

<a href="https://postimg.cc/K1zgh0vw" target="_blank">
  <img src="https://i.postimg.cc/GmPPYN0L/Dar-De-Baja.png" alt="Dar de Baja" style="width: 400px; height: auto; margin-bottom: 20px;">
</a>

  - **SUBE GOLD:** Obtén información sobre cómo obtener una tarjeta SUBE GOLD.

<a href="https://postimg.cc/PvTP34R6" target="_blank">
  <img src="https://i.postimg.cc/br2kvVHj/SubeGOLD.png" alt="SUBE GOLD" style="width: 400px; height: auto; margin-bottom: 20px;">
</a>

- **Mis Trámites:** Visualiza el estado actual de tus trámites.

<a href="https://postimg.cc/s1mYFQ4B" target="_blank">
  <img src="https://i.postimg.cc/m2f8H7cS/Estado-Reclamo-Act.png" alt="Estado de Reclamo" style="width: 400px; height: auto; margin-bottom: 20px;">
</a>

- **Salir:** Regresa al formulario principal.

### Integrantes

| Nombre  | Apellido | Github |
| ------------- | ------------- |  ------------- |
| Juan Pablo        | Cortez Fernandez  | <a href="https://github.com/JpCortezF" target="_blank">JpCortezF</a> |
| Ezequiel Anthony  | Melo              | <a href="https://github.com/EzequielMelo" target="_blank">EzequielMelo</a> |

## Licencia

Este proyecto está bajo la licencia [MIT license].

