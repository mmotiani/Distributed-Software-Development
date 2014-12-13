<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h1><center>List of Hotels</center></h1>
        <table border="1" align="center">
          <tr bgcolor="blue" style="font-size:10pt; font-family:times new roman;">
            <td rowspan="2" align="center">
              <b>Name</b>
            </td>
            <td rowspan="2" align="center">
              <b>attribute = "stars"</b>
            </td>
            <td colspan="2" align="center">
              <b>Contact</b>
            </td>
            <td colspan="5" align="center">
              <b>Address</b>
            </td>
          </tr>
          <tr bgcolor="blue" style="font-size:10pt; font-family:times new roman;">
            <td rowspan="1" align="center">
              <b>Phone</b>
            </td>
            <td colspan="1" align="center">
              <b>Email</b>
            </td>

			<td colspan="1" align="center">
              <b>attribute = "BusLines"</b>
            </td>
            <td rowspan="1" align="center">
              <b>Number</b>
            </td>
            <td colspan="1" align="center">
              <b>Street</b>
            </td>
            <td rowspan="1" align="center">
              <b>City</b>
            </td>
            <td colspan="1" align="center">
              <b>Zip</b>
            </td>
            
          </tr>

          <xsl:for-each select="Hotels/Hotel">
            <xsl:sort select="Address"/>
            <tr style="font-size:10pt; font-family:calibri">
              <td>
                <xsl:value-of select="Name"/>
              </td>
              <td>
                <xsl:value-of select="@stars"/>
              </td>

              <td>
                <xsl:value-of select="Contact/Phone"/>
              </td>
              <td>
                <xsl:value-of select="Contact/Email"/>
              </td>
			  <td>
                <xsl:value-of select="Address/@BusLines"/>
              </td>
              <td>
                <xsl:value-of select="Address/Number"/>
              </td>
              <td>
                <xsl:value-of select="Address/Street"/>
              </td>
              <td>
                <xsl:value-of select="Address/City"/>
              </td>
              <td>
                <xsl:value-of select="Address/Zip"/>
              </td>
              
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>