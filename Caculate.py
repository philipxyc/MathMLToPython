import numpy,sys
# sys.stdin.read().split(';')[-1]+='ans = '
sl=sys.stdin.read().replace('\n','').replace('\r','').split(';')
sl=[x for x in sl if x != ""]
ansl=[]
i=0
for idx in range(len(sl)):
	if(sl[idx][-1]=="="):
		ansl.append([idx,0])
		sl[idx]="ansl["+str(i)+"][1] = " +sl[idx][:-1]
		i+=1
exec(';'.join(sl))
for ans in ansl:
	if isinstance(ans[1], numpy.matrix) or isinstance(ans[1], numpy.ndarray):
		print ans[0],';',ans[1].tolist()
	else:
		print ans[0],';',ans