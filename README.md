**Desarrollo de una Biblioteca Virtual**

**Tareas:**

1. **Diseño de Clases utilizando POO:**
   - Crear las clases `Libro`, `Usuario`, `Prestamo`, y cualquier otra clase necesaria para representar las entidades en la biblioteca virtual.

2. **Implementación de Relaciones uno a muchos:**
   - Establecer relaciones como que un `Usuario` puede tener múltiples `Prestamos` (relación uno a muchos), y que un `Libro` puede estar prestado a varios `Usuarios`.

3. **Validaciones con Fluent Validations:**
   - Utilizar Fluent Validations para validar los datos ingresados por el usuario, como la validez de la fecha de devolución en un préstamo o la existencia de datos obligatorios en el registro de usuarios.

4. **Desarrollo del Patrón MVC:**
   - Implementar el patrón Modelo-Vista-Controlador (MVC) para separar las responsabilidades de la lógica de negocio, la presentación y la interacción con la base de datos. Crear modelos para las entidades, vistas para la interfaz de usuario (probablemente por consola o interfaz gráfica), y controladores para manejar la lógica y la navegación.

5. **Integración con EF Core:**
   - Utilizar Entity Framework Core (EF Core) para la persistencia de datos, facilitando la interacción con la base de datos relacional. Configurar las migraciones, contextos y configuraciones necesarias para almacenar información sobre libros, usuarios y préstamos.

6. **Implementación de Funcionalidades de Biblioteca Virtual:**
   - Desarrollar funciones como agregar libros nuevos al catálogo, registrar usuarios, gestionar préstamos (prestar y devolver libros), listar libros disponibles y préstamos activos, entre otras operaciones típicas de una biblioteca virtual.

**Características del Enunciado:**

- **Uso de POO:** Aplicación de Programación Orientada a Objetos para modelar las entidades (`Libro`, `Usuario`, `Prestamo`), permitiendo la reutilización de código y facilitando la gestión de la biblioteca.

- **Relación uno a muchos:** Implementación de relaciones donde un usuario puede tener varios préstamos y un libro puede estar prestado a varios usuarios, reflejando la dinámica de una biblioteca.

- **Fluent Validations:** Utilización de Fluent Validations para asegurar que los datos ingresados (como fechas de préstamo y devolución) sean válidos y coherentes antes de ser almacenados en la base de datos.

- **Patrón MVC:** Separación clara de responsabilidades entre modelos, vistas y controladores para mejorar la organización del código y facilitar su mantenimiento y expansión.

- **Integración con EF Core:** Utilización de EF Core para interactuar con la base de datos, aprovechando las ventajas de un ORM para gestionar de manera eficiente la persistencia de datos relacionales.

- **Funcionalidades de Biblioteca Virtual:** Implementación de un conjunto completo de funciones para gestionar un catálogo de libros, usuarios, y préstamos, proporcionando una experiencia de usuario intuitiva y eficiente.
