"""Import libreria XLRD"""
import xlrd

def saludo():
    """Prueba de saludo"""
    return ("Hola como estas")

def file():
    """Obtienes el total del contenido del archivo"""
    """ https://stackoverflow.com/questions/50950359/how-to-count-the-total-
    number-of-sheets-in-an-excel-file-using-python?fbclid=
    IwAR01tNxkUaFQWnvbgEn1Hn7QqXlR7Qc6Z94A3ZAamp4KIDaStxlzVIpwl0Y """
    book = xlrd.open_workbook('API-XLS.xls')
    files = len(book.sheet_names())
    return files

def row_col(files, hoja, rows, col):
    """Obtienes el total de las columnas y filas"""
    book = xlrd.open_workbook(files)
    sheet = book.sheet_by_index(hoja)
    rows = sheet.nrows
    col = sheet.ncols
    return ({'columnas': rows, 'filas': col})

def columns(files, hoja, col):
    """Obtiene el contenido de una columna"""
    """ https://stackoverflow.com/questions/14617477/the-col-output-in-xlrd-printing-
    something-with-appears-to-be-xf-formatting-text?fbclid=IwAR1kkmgDA_
    zfqBYM9TCp7DZSiCzprzL7U4Lbed42hdH4YO_yHM-hIGLJpLE"""
    book = xlrd.open_workbook(files)
    sheet = book.sheet_by_index(hoja)
    values = sheet.col_values(col)
    return values

def cell(files, hoja, row, col):
    """Obtiene el contenido de una celda especifica"""
    """ https://stackoverflow.com/questions/68459436/obtain-cell-
    value-after-xlrd-and-xlwt?fbclid=IwAR1sS_
    uhXi3vBFXgSuOaqrdSdrmgGbXtvZSfLFEdnSvyVx9uV-nNwcNTcTw"""
    book = xlrd.open_workbook(files)
    sheet = book.sheet_by_index(hoja)
    cols_rows = sheet.cell_value(row, col)
    return cols_rows


def matrix(files, hoja):
    """Obtiene la hoja del archivo en una matriz ordenada"""
    """ https://stackoverflow.com/questions/27247832/creating-matrix-by-reading-data-from-excel"""
    book = xlrd.open_workbook(files)
    sheet = book.sheet_by_index(hoja)
    matrix = []
    for row in range (sheet.nrows):
        data_row=[]
        for col in range (sheet.ncols):
            data_row.append(sheet.cell_value(row,col))
        matrix.append(data_row)
    return matrix
