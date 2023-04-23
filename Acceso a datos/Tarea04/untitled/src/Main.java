import java.sql.*;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {
    public static Connection conn;

    public static void main(String[] args) throws SQLException, ClassNotFoundException {
        Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        conn = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databaseName=JDBC;trustServerCertificate=true;", "sa", "root");
        Setup();
    }

    private static void Setup() {
        Scanner scanner = new Scanner(System.in);
        int choice;

        do {
            System.out.println("/*********************************************************/");
            System.out.println("                    Bienvenido                            ");
            System.out.println("/*********************************************************/");
            System.out.println("1. Oficinas de galicia");
            System.out.println("2. Insertar Empleado  ");
            System.out.println("3. reducir un 10% el importe de todos los pedidos");
            System.out.println("4. Actualiza las cantidades de todos los pedidos cuyo importe sea menor a 3€");
            System.out.println("5. Utilizando una transacción");
            System.out.println("6. Salir");
            System.out.print("Elige una opción: ");
            choice = scanner.nextInt();

            switch (choice) {
                case 1:
                    Opcion1();
                    break;
                case 2:
                    Opcion2();
                    break;
                case 3:
                    Opcion3();
                    break;
                case 4:
                    Opcion4();
                    break;
                case 5:
                    Opcion5();
                    break;
                case 6:
                    System.out.println("Hasta luego");
                    break;
                default:
                    System.out.println("Opción no válida");
                    break;
            }
        } while (choice != 6);
        scanner.close();
    }


    private static void Opcion1() {
        //2. Obtenga las ciudades de todas las oficinas de Galicia (0,5 puntos)
        System.out.println("\033[38;5;208m2. Obtenga las ciudades de todas las oficinas de Galicia\033[0m");
        try {
            String oficina = "Galicia";
            GetListaCiudades(oficina);
        } catch (InputMismatchException e) {
            System.out.println("Datos incorrectos.");
        }

    }

    private static void Opcion2() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("\033[38;5;208m3. Permita insertar registros en la tabla EMP utilizando consultas parametrizadas\033[0m");
        try {
            //3. Permita insertar registros en la tabla EMP utilizando consultas parametrizadas
            System.out.println("Numero Empleado: ");
            int numero = scanner.nextInt();
            System.out.println("Nombre Empleado: ");
            String nombreEmpleado = scanner.next();
            InsertEmp(numero, nombreEmpleado);
        } catch (InputMismatchException e) {
            System.out.println("\033[31mPor favor ingresa un número entero válido.\033[0m");
        }
    }

    private static void Opcion3() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("\033[38;5;208m4. Permita reducir un 10% el importe de todos los pedidos\033[0m");
        try {
            //4. Permita reducir un 10% el importe de todos los pedidos
            System.out.println("Porcentaje a reducir");
            int porcentaje = scanner.nextInt();
            ReducirImportePedidos(porcentaje);
        } catch (InputMismatchException e) {
            System.out.println("\033[31mPor favor ingresa un número entero válido.\033[0m");
        }
    }

    private static void Opcion4() {
        //Actualiza las cantidades de todos los pedidos cuyo importe sea menor a 3€
        System.out.println("\033[38;5;208m5.Actualiza las cantidades de todos los pedidos cuyo importe sea menor a 3€\033[0m");
        Scanner scanner = new Scanner(System.in);
        try {
            int importe = 3;
            System.out.println("Cantidad nueva");
            int cantidad = scanner.nextInt();
            ReducirImportePedidosByImporte(importe, cantidad);
        } catch (InputMismatchException e) {
            System.out.println("\033[31mPor favor ingresa un número entero válido.\033[0m");
        }
    }

    private static void Opcion5() {

        Scanner scanner = new Scanner(System.in);
        //Insertar un registro en la tabla BONUS (0,5 puntos)
        try {
            System.out.println("\033[38;5;208mDesactivamos el autoCommit \033[0m");
            //Desactivamos el autoCommit
            conn.setAutoCommit(false);

            //Insert Bonus
            System.out.println("\033[38;5;208mInsertar un registro en la tabla BONUS \033[0m");
            int cantidad = scanner.nextInt();
            InsertBonus(cantidad);

            System.out.println("\033[38;5;208mBorra todos aquellos empleados mayores de 40 años\033[0m");
            //Borrado de empleados
            DeleteEmpleado(40);

            System.out.println("\033[38;5;208mPermita borrar todos los registros de la tabla SALGRADE\033[0m");
            //Borrado Salgrade
            DeleteSalgrade();

            System.out.println("\033[38;5;208mMuestra las localizaciones de todos los departamentos\033[0m");
            //Obtener las localizaciones LOC
            GetLocalizacionesDepartamentos("");

            System.out.println("\033[38;5;208mCOMMIT\033[0m");
            //Guardamos los cambios realizados
            conn.commit();

            System.out.println("\033[38;5;208msetAutoCommit(true)\033[0m");
            //Activos el autocommit
            conn.setAutoCommit(true);
        } catch (SQLException e) {
            //En caso de error deshacemos los cambios
            try {
                conn.rollback();
            } catch (SQLException ex) {
                System.out.println(e.getMessage());
            }
            System.out.println(e.getMessage());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    //6.4 Muestra las localizaciones de todos los departamentos (0,5 puntos)
    private static void GetLocalizacionesDepartamentos(String ciudades) {

        try {
            Statement stmt = conn.createStatement();
            String queryOficinas = "SELECT DEPTNO " + ",DNAME" + " ,LOC " + "  FROM DEPT";
            PreparedStatement stament = conn.prepareStatement(queryOficinas);
            ResultSet resultados = stament.executeQuery();
            while (resultados.next()) {
                System.out.println("\033[34m" + resultados.getString("LOC") + "\033[0m");
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }


    //6.3o Permita borrar todos los registros de la tabla SALGRADE (0,5 puntos)
    private static void DeleteSalgrade() throws SQLException, ClassNotFoundException {
        try {

            PreparedStatement pstmt = null;
            Statement stmt = conn.createStatement();
            String insertQuery = "DELETE FROM SALGRADE ";

            pstmt = conn.prepareStatement(insertQuery);

            int rowsAffected = pstmt.executeUpdate();
            if (rowsAffected > 0) {
                System.out.println("\033[34mEmpleados Borrados\033[0m");
            }

        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }

    }

    //6.2 o Borra todos aquellos empleados mayores de 40 años (0,5 puntos)
    private static void DeleteEmpleado(int edadEmpleados) {
        try {
            PreparedStatement pstmt = null;
            Statement stmt = conn.createStatement();
            String insertQuery = "DELETE FROM empleados " + "WHERE edad > ?";

            pstmt = conn.prepareStatement(insertQuery);
            pstmt.setInt(1, edadEmpleados);

            int rowsAffected = pstmt.executeUpdate();
            if (rowsAffected > 0) {
                System.out.println("\033[34mEmpleados Borrados\033[0m");
            }
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }

    }

    //6.1 Insertar un registro en la tabla BONUS (0,5 puntos)
    private static void InsertBonus(int bonus) {

        try {
            PreparedStatement pstmt = null;
            Statement stmt = conn.createStatement();
            String insertQuery = "INSERT INTO BONUS (ENAME ,JOB ,SAL ,COMM)" + "VALUES (?,?,?,?)";


            pstmt = conn.prepareStatement(insertQuery);
            pstmt.setInt(1, bonus);
            pstmt.setString(2, "55555");
            pstmt.setString(3, "55555");
            pstmt.setString(4, "55555");

            int rowsAffected = pstmt.executeUpdate();
            if (rowsAffected > 0) {
                System.out.println("\033[34mInsertado Bonus\033[0m");
            }
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

    //5. Actualiza las cantidades de todos los pedidos cuyo importe sea menor a 3€ (0,5//puntos)
    private static void ReducirImportePedidosByImporte(int importe, int cantidad) {
        try {
            PreparedStatement pstmt = null;

            Statement stmt = conn.createStatement();

            String queryUpdateImportePedido = "UPDATE pedidos " + "SET cantidad = ? " + "Where importe < ?";

            pstmt = conn.prepareStatement(queryUpdateImportePedido);
            pstmt.setInt(1, cantidad);
            pstmt.setInt(2, importe);

            int rowsAffected = pstmt.executeUpdate();
            if (rowsAffected > 0) {
                System.out.println("\033[34mImporte reducido\033[0m");
            }

        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

    //4. Permita reducir un 10% el importe de todos los pedidos (0,5 puntos)
    private static void ReducirImportePedidos(int porcentaje) {

        try {
            PreparedStatement pstmt = null;
            Statement stmt = conn.createStatement();

            String queryUpdateImportePedido = "UPDATE pedidos " + "SET importe = importe - (importe *?/100)";

            pstmt = conn.prepareStatement(queryUpdateImportePedido);
            pstmt.setInt(1, porcentaje);


            int rowsAffected = pstmt.executeUpdate();
            if (rowsAffected > 0) {
                System.out.println("\033[34mImporte reducido\033[0m");
            }
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }

    }

    //2. Obtenga las ciudades de todas las oficinas de Galicia (0,5 puntos)
    private static void GetListaCiudades(String ciudades) {

        try {
            // Abrir la conexión
            Statement stmt = conn.createStatement();
            String queryOficinas = "SELECT oficina,region,ciudad  from oficinas where region = ?";
            PreparedStatement stament = conn.prepareStatement(queryOficinas);
            stament.setString(1, ciudades);
            ResultSet resultados = stament.executeQuery();

            while (resultados.next()) {
                System.out.println("\033[34m Ciudad => " + resultados.getString("ciudad") + "\033[0m");
            }

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    //3. Permita insertar registros en la tabla EMP utilizando consultas parametrizadas (0,5 puntos)
    private static void InsertEmp(int emp_number, String nombre_empleado) {

        try {
            // Abrir la conexión
            PreparedStatement pstmt = null;
            Statement stmt = conn.createStatement();
            //3. Permita insertar registros en la tabla EMP utilizando consultas parametrizadas (0,5 puntos)
            String insertQuery = "INSERT INTO EMP (EMPNO, ENAME, JOB , MGR ,HIREDATE ,SAL, COMM, DEPTNO)" + " VALUES( ?,?, '', NULL, NULL, NULL ,NULL ,'');";

            pstmt = conn.prepareStatement(insertQuery);
            pstmt.setInt(1, emp_number);
            pstmt.setString(2, nombre_empleado);

            int rowsAffected = pstmt.executeUpdate();
            if (rowsAffected > 0) {
                System.out.println("\033[34mEmpleado insertado\033[0m");
            }
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
