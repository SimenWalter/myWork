data work.emp1;
*Creating a library called work and a dataset called emp1;
    infile "&path/Walking-Cycling.csv" dlm=',';
	*infile reads the raw data file;
    length Freq $ 12;
	*This states the length of the variable Freq; 
    input Freq $ Walking_percent Cycling_percent;
run;

proc print data=work.emp1 noobs;
run;
