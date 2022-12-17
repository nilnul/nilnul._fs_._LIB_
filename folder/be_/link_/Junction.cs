namespace nilnul.fs.folder.be_
{
	 class Junction
	//: BeI
	{

	}
	/*

A Junction Point is very much like a Symbolic Link, except that it can only point to a folder, not to a file.

	Junction Points are slightly different in that they always return an absolute path, which, as far as I can tell, is worked out when the Junction Point is created. Nevertheless, there is still no guarantee that it is a valid path, or that it exists when the Junction point is accessed (remember that the actual target may have been deleted or moved since the Reparse Point was created). The function I have implemented takes the path and, if it is a symbolic link and a relative path, "normalises" it by appending it to the drive and path of the passed Reparse Point to convert it to an absolute path. Note, however, that the target path may quite legally contain .s or ..s. These could also be "normalised", but I don't bother.

	 */
}


