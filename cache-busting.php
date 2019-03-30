<?php
	function get_that_filetime($file_url = false) {
		if($file_url && file_exists($file_url)) {
			return filemtime($file_url);
		}
	}
?>
