
import pyodbc
import json

def get_connection():
    conn_str = (
        "DRIVER={ODBC Driver 17 for SQL Server};"
        "SERVER=172.16.32.15;"
        "DATABASE=ZEUS_RT_DEV;"
        "UID=sa;"
        "PWD=R4ck$2023.;"
        "TrustServerCertificate=yes;"
    )
    return pyodbc.connect(conn_str)

def check_equivalences():
    conn = get_connection()
    cursor = conn.cursor()

    # Get count of equivalences
    cursor.execute("SELECT COUNT(*) FROM MATERIA_EQUIVALENTE")
    count = cursor.fetchone()[0]
    print(f"Total MATERIA_EQUIVALENTE rows: {count}")

    # Get some sample equivalences with their plan names
    query = """
    SELECT TOP 10 
        me.ID_MALLA, 
        pe.CODIGO_PLAN_ESTUDIO_MALLA, 
        mat.NOMBRE_MATERIA,
        me.ID_MALLA_EQUIV,
        pe_eq.CODIGO_PLAN_ESTUDIO_MALLA as PLAN_EQ,
        mat_eq.NOMBRE_MATERIA as MATERIA_EQ,
        me.PORC_EQUIV
    FROM MATERIA_EQUIVALENTE me
    JOIN MALLA m ON me.ID_MALLA = m.ID_MALLA
    JOIN PLAN_ESTUDIO pe ON m.ID_PLAN_ESTUDIO = pe.ID_PLAN_ESTUDIO
    JOIN MATERIA mat ON m.ID_MATERIA = mat.ID_MATERIA
    LEFT JOIN MALLA m_eq ON me.ID_MALLA_EQUIV = m_eq.ID_MALLA
    LEFT JOIN PLAN_ESTUDIO pe_eq ON m_eq.ID_PLAN_ESTUDIO = pe_eq.ID_PLAN_ESTUDIO
    LEFT JOIN MATERIA mat_eq ON m_eq.ID_MATERIA = mat_eq.ID_MATERIA
    """
    cursor.execute(query)
    rows = cursor.fetchall()
    
    print("\nSample Equivalences:")
    for row in rows:
        print(f"Plan: {row.CODIGO_PLAN_ESTUDIO_MALLA}, Mat: {row.NOMBRE_MATERIA} -> EqPlan: {row.PLAN_EQ}, EqMat: {row.MATERIA_EQ}, %: {row.PORC_EQUIV}")

    conn.close()

if __name__ == "__main__":
    check_equivalences()
