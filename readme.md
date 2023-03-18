# CSV Data Generator
Simple command line tool to generate CSV files with random data.

## Command line
```shell
csvdatagen.exe <output filename.csv - default: data.csv> <number of records - default: 1000>
```

### Examples

Creates a file called `new_data.csv` with 99,999 records.
```shell
csvdatagen.exe new_data.csv 99999
```

Creates a file called `data.csv` with 1,000 records.
```shell
csvdatagen.exe
```